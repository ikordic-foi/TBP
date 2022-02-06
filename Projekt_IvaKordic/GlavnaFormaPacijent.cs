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
    public partial class GlavnaFormaPacijent : Form
    {
        pacijent pacijent;
        public GlavnaFormaPacijent(pacijent pacijent)
        {
            InitializeComponent();
            this.pacijent = pacijent;
            lblDatum.Text = DateTime.Now.Date.ToShortDateString();
            lblPacijent.Text = pacijent.ToString();
            lblDatumZaceca.Text = pacijent.datum_zaceca.HasValue 
                ? pacijent.datum_zaceca.Value.ToShortDateString() : "";
            
            PrikaziPreglede();
            PrikaziZakazanePreglede();
            PrikaziTromjesjecja();

            ProvjeriTromjesjecje();
            ProvjeriImeOcaISpol();
        }

        private void ProvjeriTromjesjecje()
        {
            if (lblDatumZaceca.Text == "")
            {
                lblTromjesjecje.Text = "";
            }
            else
            {
                lblTromjesjecje.Text = lblDatumZaceca.Text;
            }
        }

        private void ProvjeriImeOcaISpol()
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                kontekst.pacijent.Attach(pacijent);

                if (pacijent.dijete.First().ime_oca == null)
                {
                    tbImeOca.Enabled = true;
                }
                else
                {
                    tbImeOca.Enabled = false;
                }

                tbImeOca.Text = pacijent.dijete.First().ime_oca;
                lblSpol.Text = pacijent.dijete.First().spol;
                lblPrezime.Text = pacijent.dijete.First().prezime;
            }
        }

        private void PrikaziTromjesjecja()
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                var query = from t in kontekst.tromjesjecje
                            where t.majka_id == pacijent.id
                            select t;

                List<tromjesjecje> tromjesjecja = query.ToList();
                tromjesjecja.Sort((x, y) => DateTime.Compare(x.pocetak, y.pocetak));
                dgvTromjesjecja.DataSource = tromjesjecja;
                dgvTromjesjecja.Columns["id"].Visible = false;
                dgvTromjesjecja.Columns["majka_id"].Visible = false;
                dgvTromjesjecja.Columns["pacijent"].Visible = false;
                dgvTromjesjecja.Columns["opis"].Visible = false;
            }
        }

        private void PrikaziPreglede()
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                var query = from p in kontekst.pregled
                            join dp in kontekst.doktor_pacijent
                            on p.doktor_id equals dp.doktor_id
                            where dp.pacijent_id == pacijent.id
                            && p.pacijent_id == pacijent.id
                            && p.zapis != null
                            select p;

                List<pregled> pregledi = query.ToList();
                pregledi.Sort((x, y) => DateTime.Compare(x.datum, y.datum));
                dgvPregledi.DataSource = pregledi;
                dgvPregledi.Columns["id"].Visible = false;
                dgvPregledi.Columns["doktor_id"].Visible = false;
                dgvPregledi.Columns["pacijent_id"].Visible = false;
                dgvPregledi.Columns["doktor"].Visible = false;
                dgvPregledi.Columns["pacijent"].Visible = false;
            }
        }

        private void PrikaziZakazanePreglede()
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                var query = from p in kontekst.pregled
                            join dp in kontekst.doktor_pacijent
                            on p.doktor_id equals dp.doktor_id
                            where dp.pacijent_id == pacijent.id
                            && p.pacijent_id == pacijent.id
                            && p.zapis == null
                            select p;

                List<pregled> buduciPregledi = query.ToList();
                buduciPregledi.Sort((x, y) => DateTime.Compare(x.datum, y.datum));
                dgvZakazaniPregledi.DataSource = buduciPregledi;
                dgvZakazaniPregledi.Columns["id"].Visible = false;
                dgvZakazaniPregledi.Columns["doktor_id"].Visible = false;
                dgvZakazaniPregledi.Columns["pacijent_id"].Visible = false;
                dgvZakazaniPregledi.Columns["doktor"].Visible = false;
                dgvZakazaniPregledi.Columns["zapis"].Visible = false;
                dgvZakazaniPregledi.Columns["pacijent"].Visible = false;
            }
        }

        private void btnDnevnik_Click(object sender, EventArgs e)
        {
            DnevnikForma dnevnik = new DnevnikForma(pacijent, true);
            dnevnik.ShowDialog();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (tbImeOca.Enabled && tbImeOca.Text.Length > 0)
            {
                using (var kontekst = new projekt_tbpEntities())
                {
                    kontekst.pacijent.Attach(pacijent);

                    pacijent.dijete.First().ime_oca = tbImeOca.Text;

                    try
                    {
                        kontekst.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Neuspješno ažuriranje podataka");
                    }
                }

                ProvjeriImeOcaISpol();
            }
        }

        private void dgvTromjesjecja_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTromjesjecja.SelectedRows.Count == 1)
            {
                tromjesjecje tromjesjecje = dgvTromjesjecja.CurrentRow.DataBoundItem as tromjesjecje;

                rtbDetaljniOpisTromjesjecja.Text = tromjesjecje.opis;
            }
        }

        private void dgvPregledi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPregledi.SelectedRows.Count == 1)
            {
                pregled pregled = dgvPregledi.CurrentRow.DataBoundItem as pregled;

                PrikaziPovijestKilaze(pregled);
                PrikaziPovijestOpsega(pregled);
                PrikaziMjere(pregled);

                rtbZapisPregleda.Text = pregled.zapis;
            }
        }

        private void PrikaziMjere(pregled pregled)
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                var query = from mp in kontekst.mjere_ploda
                            join d in kontekst.dijete
                            on mp.dijete_id equals d.id
                            where d.majka_id == pacijent.id
                            && mp.datum == pregled.datum
                            select mp;

                List<mjere_ploda> mjere = query.ToList();
                dgvMjere.DataSource = mjere;
                dgvMjere.Columns["id"].Visible = false;
                dgvMjere.Columns["dijete_id"].Visible = false;
                dgvMjere.Columns["dijete"].Visible = false;
            }
        }

        private void PrikaziPovijestOpsega(pregled pregled)
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                var query = from o in kontekst.opseg
                            where o.majka_id == pacijent.id
                            && o.datum == pregled.datum
                            select o;

                List<opseg> opsezi = query.ToList();
                dgvOpsezi.DataSource = opsezi;
                dgvOpsezi.Columns["id"].Visible = false;
                dgvOpsezi.Columns["majka_id"].Visible = false;
                dgvOpsezi.Columns["pacijent"].Visible = false;
            }
        }

        private void PrikaziPovijestKilaze(pregled pregled)
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                var query = from k in kontekst.kilaza
                            where k.majka_id == pacijent.id
                            && k.datum == pregled.datum
                            select k;

                List<kilaza> kilaze = query.ToList();
                dgvKilaze.DataSource = kilaze;
                dgvKilaze.Columns["id"].Visible = false;
                dgvKilaze.Columns["majka_id"].Visible = false;
                dgvKilaze.Columns["pacijent"].Visible = false;
            }
        }
    }
}
