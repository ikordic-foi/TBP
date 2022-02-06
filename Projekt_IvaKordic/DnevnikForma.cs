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
    public partial class DnevnikForma : Form
    {
        pacijent pacijent;
        public DnevnikForma(pacijent pacijent, bool prijavljeniPacijent)
        {
            InitializeComponent();
            this.pacijent = pacijent;
            lblDatum.Text = DateTime.Now.Date.ToShortDateString();
            lblPacijent.Text = pacijent.ToString();
            PrikaziDnevnik();
            OgraniciPristup(prijavljeniPacijent);
        }

        private void OgraniciPristup(bool prijavljeniPacijent)
        {
            if (prijavljeniPacijent)
            {
                lblLabelPacijenta.Text = "Prijavljeni pacijent:";
                rtbDetaljniOpis.Enabled = true;
                btnNoviZapis.Visible = true;
                btnSpremi.Visible = true;
            }
            else
            {
                lblLabelPacijenta.Text = "Odabrani pacijent:";
                btnNoviZapis.Visible = false;
                btnSpremi.Visible = false;
            }
        }

        private void PrikaziDnevnik()
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                var query = from d in kontekst.dnevnik
                            where d.majka_id == pacijent.id
                            select d;

                List<dnevnik> zapisiDnevnika = query.ToList();
                zapisiDnevnika.Sort((x, y) => DateTime.Compare(x.datum, y.datum));
                dgvZapisiDnevnika.DataSource = zapisiDnevnika;
                dgvZapisiDnevnika.Columns["id"].Visible = false;
                dgvZapisiDnevnika.Columns["majka_id"].Visible = false;
                dgvZapisiDnevnika.Columns["pacijent"].Visible = false;
                dgvZapisiDnevnika.Columns["opis"].Visible = false;
            }
        }

        private void dgvZapisiDnevnika_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvZapisiDnevnika.SelectedRows.Count == 1)
            {
                dnevnik dnevnik = dgvZapisiDnevnika.CurrentRow.DataBoundItem as dnevnik;

                rtbDetaljniOpis.Text = dnevnik.opis;
            }
        }

        private void btnNoviZapis_Click(object sender, EventArgs e)
        {
            NoviZapisDnevnikaForma noviZapis = new NoviZapisDnevnikaForma(pacijent);
            noviZapis.ShowDialog();
            PrikaziDnevnik();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (dgvZapisiDnevnika.SelectedRows.Count == 1)
            {
                dnevnik dnevnik = dgvZapisiDnevnika.CurrentRow.DataBoundItem as dnevnik;

                using (var kontekst = new projekt_tbpEntities())
                {
                    kontekst.dnevnik.Attach(dnevnik);

                    dnevnik.opis = rtbDetaljniOpis.Text;

                    try
                    {
                        kontekst.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Neuspješno ažuriranje zapisa");
                        kontekst.dnevnik.Remove(dnevnik);
                    }
                }
            }
            
        }
    }
}
