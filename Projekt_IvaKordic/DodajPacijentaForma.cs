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
    public partial class DodajPacijentaForma : Form
    {
        doktor doktor;
        public DodajPacijentaForma(doktor doktor)
        {
            InitializeComponent();
            this.doktor = doktor;
            PrikaziPacijente();
        }

        private void PrikaziPacijente()
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                var query = from pa in kontekst.pacijent
                            where pa.doktor_pacijent.All(p => !(p.doktor_id == doktor.id))
                            select pa;

                List<pacijent> pacijenti = query.ToList();

                dgvSviPacijenti.DataSource = pacijenti;
                dgvSviPacijenti.Columns["id"].Visible = false;
                dgvSviPacijenti.Columns["dijete"].Visible = false;
                dgvSviPacijenti.Columns["dnevnik"].Visible = false;
                dgvSviPacijenti.Columns["doktor_pacijent"].Visible = false;
                dgvSviPacijenti.Columns["kilaza1"].Visible = false;
                dgvSviPacijenti.Columns["uloga"].Visible = false;
                dgvSviPacijenti.Columns["opseg"].Visible = false;
                dgvSviPacijenti.Columns["tromjesjecje"].Visible = false;
                dgvSviPacijenti.Columns["pregled"].Visible = false;
            }
        }

        private void btnDodajPacijenta_Click(object sender, EventArgs e)
        {
            DodajPacijenta();
        }

        private void DodajPacijenta()
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                pacijent pacijent = null;

                if (dgvSviPacijenti.SelectedRows.Count == 1)
                {
                    pacijent = dgvSviPacijenti.CurrentRow.DataBoundItem as pacijent;

                    doktor_pacijent dp = new doktor_pacijent
                    {
                        pacijent_id = pacijent.id,
                        doktor_id = doktor.id
                    };

                    try
                    {
                        kontekst.doktor_pacijent.Add(dp);
                        kontekst.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Neuspješno dodavanje pacijenta");
                    }
                }
                else
                {
                    MessageBox.Show("Morate odabrati pacijenta");
                }
            }

            PrikaziPacijente();
        }
    }
}
