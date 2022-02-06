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
    public partial class TromjesjecjaForma : Form
    {
        pacijent pacijent;
        public TromjesjecjaForma(doktor doktor, pacijent pacijent)
        {
            InitializeComponent();
            this.pacijent = pacijent;
            lblPacijent.Text = pacijent.ToString();
            lblDatum.Text = DateTime.Now.Date.ToShortDateString();
            PrikaziTromjesjecja();
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

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                if (dgvTromjesjecja.SelectedRows.Count == 1)
                {
                    tromjesjecje tromjesjecje = dgvTromjesjecja.CurrentRow.DataBoundItem as tromjesjecje;

                    kontekst.tromjesjecje.Attach(tromjesjecje);

                    tromjesjecje.opis = rtbDetaljniOpis.Text;

                    try
                    {
                        kontekst.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Neuspjelo ažuriranje tromjesječja");
                    }
                }
            }
        }

        private void dgvTromjesjecja_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTromjesjecja.SelectedRows.Count == 1)
            {
                tromjesjecje tromjesjecje = dgvTromjesjecja.CurrentRow.DataBoundItem as tromjesjecje;

                rtbDetaljniOpis.Text = tromjesjecje.opis;
            }
        }
    }
}
