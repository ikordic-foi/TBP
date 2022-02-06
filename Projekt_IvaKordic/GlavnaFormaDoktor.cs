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
    public partial class GlavnaFormaDoktor : Form
    {
        doktor doktor;
        public GlavnaFormaDoktor(doktor doktor)
        {
            InitializeComponent();
            this.doktor = doktor;
            lblPrijavljeniDoktor.Text = doktor.ToString();
            lblDatum.Text = DateTime.Now.Date.ToShortDateString();
            PrikaziPacijente();
        }

        private void btnPregledi_Click(object sender, EventArgs e)
        {
            pacijent pacijent = null;

            if (dgvPacijenti.SelectedRows.Count == 1)
            {
                pacijent = dgvPacijenti.CurrentRow.DataBoundItem as pacijent;

                PreglediForma pregledi = new PreglediForma(doktor, pacijent);
                pregledi.ShowDialog();
            }
            else
            {
                MessageBox.Show("Morate odabrati pacijenta");
            }
        }

        private void btnDnevnik_Click(object sender, EventArgs e)
        {
            pacijent pacijent = null;

            if (dgvPacijenti.SelectedRows.Count == 1)
            {
                pacijent = dgvPacijenti.CurrentRow.DataBoundItem as pacijent;

                DnevnikForma dnevnik = new DnevnikForma(pacijent, false);
                dnevnik.ShowDialog();
            }
            else
            {
                MessageBox.Show("Morate odabrati pacijenta");
            }
        }

        private void btnTromjesjecja_Click(object sender, EventArgs e)
        {
            pacijent pacijent = null;

            if (dgvPacijenti.SelectedRows.Count == 1)
            {
                pacijent = dgvPacijenti.CurrentRow.DataBoundItem as pacijent;

                TromjesjecjaForma tromjesjecja = new TromjesjecjaForma(doktor, pacijent);
                tromjesjecja.ShowDialog();
            }
            else
            {
                MessageBox.Show("Morate odabrati pacijenta");
            }
        }

        private void btnNoviPacijent_Click(object sender, EventArgs e)
        {
            DodajPacijentaForma dodajPacijentaForma = new DodajPacijentaForma(doktor);
            dodajPacijentaForma.ShowDialog();
            PrikaziPacijente();
        }

        private void PrikaziPacijente()
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                var query = from pa in kontekst.pacijent
                            join p in kontekst.doktor_pacijent
                            on pa.id equals p.pacijent_id
                            where p.doktor_id == doktor.id
                            select pa;

                List < pacijent > pacijenti = query.ToList();

                dgvPacijenti.DataSource = pacijenti;
                dgvPacijenti.Columns["id"].Visible = false;
                dgvPacijenti.Columns["dijete"].Visible = false;
                dgvPacijenti.Columns["dnevnik"].Visible = false;
                dgvPacijenti.Columns["doktor_pacijent"].Visible = false;
                dgvPacijenti.Columns["kilaza1"].Visible = false;
                dgvPacijenti.Columns["uloga"].Visible = false;
                dgvPacijenti.Columns["opseg"].Visible = false;
                dgvPacijenti.Columns["tromjesjecje"].Visible = false;
                dgvPacijenti.Columns["pregled"].Visible = false;
            }
        }
    }
}
