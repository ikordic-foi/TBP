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
    public partial class ZakaziPregledForma : Form
    {
        doktor doktor;
        pacijent pacijent;
        public ZakaziPregledForma(doktor doktor, pacijent pacijent)
        {
            InitializeComponent();
            this.doktor = doktor;
            this.pacijent = pacijent;
            lblPacijent.Text = pacijent.ToString();
            dtpDatumPregleda.Format = DateTimePickerFormat.Custom;
            dtpDatumPregleda.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            SpremiPregled();
        }

        private void SpremiPregled()
        {
            using (var kontekst = new projekt_tbpEntities())
            {

                pregled pregled = new pregled
                {
                    doktor_id = doktor.id,
                    pacijent_id = pacijent.id,
                    vrsta = tbVrsta.Text,
                    datum = DateTime.Parse(dtpDatumPregleda.Value.ToShortDateString() + " " + dtpDatumPregleda.Value.ToShortTimeString())
                };

                try
                {
                    kontekst.pregled.Add(pregled);
                    kontekst.SaveChanges();
                    Close();
                }
                catch (Exception e)
                {
                    kontekst.pregled.Remove(pregled);
                    if (e.InnerException.InnerException is PostgresException)
                    {
                        MessageBox.Show(e.InnerException.InnerException.Message);
                    }
                    else
                    {
                        MessageBox.Show("Neuspješno zakazivanje pregleda");
                    }
                }
            }
        }
    }
}
