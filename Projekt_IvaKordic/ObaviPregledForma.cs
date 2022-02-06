using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_IvaKordic
{
    public partial class ObaviPregledForma : Form
    {
        pregled pregled;
        projekt_tbpEntities kontekst;
        public ObaviPregledForma(pregled pregled)
        {
            InitializeComponent();
            kontekst = new projekt_tbpEntities();
            kontekst.pregled.Attach(pregled);

            this.pregled = pregled;
            lblPacijent.Text = pregled.pacijent.ToString();
            tbVrsta.Text = pregled.vrsta;
            dtpDatumPregleda.Format = DateTimePickerFormat.Custom;
            dtpDatumPregleda.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDatumPregleda.Value = pregled.datum;

            ProvjeriSpol();
            ProvjeriDatumZaceca();
        }

        private void ProvjeriSpol()
        {
            if (pregled.pacijent.dijete.First().spol == null)
            {
                tbSpol.Enabled = true;
            }
            else
            {
                tbSpol.Enabled = false;
            }

            tbSpol.Text = pregled.pacijent.dijete.First().spol;
            tbImeOca.Text = pregled.pacijent.dijete.First().ime_oca;
            
        }

        private void ProvjeriDatumZaceca()
        {
            
            if (pregled.pacijent.datum_zaceca == null)
            {
                dtpDatumZaceca.Enabled = true;

            }
            else
            {
                dtpDatumZaceca.Enabled = false;
                dtpDatumZaceca.Value = (DateTime)pregled.pacijent.datum_zaceca;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            SpremiPregled();
        }

        private void SpremiPregled()
        {
            string zapis = rtbZapis.Text;
            float kilazaTrudnice = float.Parse(tbKilaza.Text);
            float opsegTrbuha = float.Parse(tbOpsegTrbuha.Text);
            float opsegPloda = float.Parse(tbOpsegPloda.Text);
            float duzinaPloda = float.Parse(tbDuzinaPloda.Text);
            tromjesjecje prvo = null;
            tromjesjecje drugo = null;
            tromjesjecje trece = null;

            pregled.zapis = zapis;

            if (tbSpol.Enabled && tbSpol.Text.Length > 0)
            {
                pregled.pacijent.dijete.First().spol = tbSpol.Text;
            }

            if (dtpDatumZaceca.Enabled)
            {
                pregled.pacijent.datum_zaceca = dtpDatumZaceca.Value;

                prvo = new tromjesjecje
                {
                    pocetak = dtpDatumZaceca.Value,
                    kraj = dtpDatumZaceca.Value.AddMonths(3),
                    majka_id = pregled.pacijent_id
                };

                drugo = new tromjesjecje
                {
                    pocetak = prvo.kraj,
                    kraj = prvo.kraj.AddMonths(3),
                    majka_id = pregled.pacijent_id
                };

                trece = new tromjesjecje
                {
                    pocetak = drugo.kraj,
                    kraj = drugo.kraj.AddMonths(3),
                    majka_id = pregled.pacijent_id
                };

                kontekst.tromjesjecje.Add(prvo);
                kontekst.tromjesjecje.Add(drugo);
                kontekst.tromjesjecje.Add(trece);
            }

            mjere_ploda mjerePloda = new mjere_ploda
            {
                datum = pregled.datum,
                duzina = duzinaPloda,
                opseg = opsegPloda,
                dijete_id = pregled.pacijent.dijete.First().id
            };

            opseg opseg = new opseg
            {
                datum = pregled.datum,
                opseg1 = opsegTrbuha,
                majka_id = pregled.pacijent.id
            };

            kilaza kilaza = new kilaza
            {
                datum = pregled.datum,
                kilaza1 = kilazaTrudnice,
                majka_id = pregled.pacijent.id
            };

            try
            {
                kontekst.mjere_ploda.Add(mjerePloda);
                kontekst.kilaza.Add(kilaza);
                kontekst.opseg.Add(opseg);

                kontekst.SaveChanges();
                Close();
            }
            catch (Exception e)
            {
                if (e.InnerException.InnerException is PostgresException)
                {
                    MessageBox.Show(e.InnerException.InnerException.Message);
                    kontekst.opseg.Remove(opseg);
                    kontekst.kilaza.Remove(kilaza);
                    kontekst.mjere_ploda.Remove(mjerePloda);
                    if (dtpDatumZaceca.Enabled)
                    {
                        kontekst.tromjesjecje.Remove(prvo);
                        kontekst.tromjesjecje.Remove(drugo);
                        kontekst.tromjesjecje.Remove(trece);
                    }
                }
                else
                {
                    MessageBox.Show("Neuspješno ažuriraje pregleda");
                }
            }
        }
    }
}
