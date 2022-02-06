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
    public partial class PreglediForma : Form
    {
        doktor doktor;
        pacijent pacijent;
        public PreglediForma(doktor doktor, pacijent pacijent)
        {
            InitializeComponent();
            this.pacijent = pacijent;
            this.doktor = doktor;
            lblPacijent.Text = pacijent.ToString();
            lblDatum.Text = DateTime.Now.Date.ToShortDateString();
            PrikaziZakazanePreglede();
            PrikaziPreglede();
        }

        private void PrikaziPreglede()
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                var query = from p in kontekst.pregled.Include("pacijent")
                            where p.doktor_id == doktor.id && p.pacijent_id == pacijent.id
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
                var query = from p in kontekst.pregled.Include("pacijent")
                            where p.doktor_id == doktor.id && p.pacijent_id == pacijent.id
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

        private void btnZakaziPregled_Click(object sender, EventArgs e)
        {
            ZakaziPregledForma zakaziPregled = new ZakaziPregledForma(doktor, pacijent);
            zakaziPregled.ShowDialog();
            PrikaziZakazanePreglede();
        }

        private void btnObaviPregled_Click(object sender, EventArgs e)
        {
            if (dgvZakazaniPregledi.SelectedRows.Count == 1)
            {
                pregled pregled = dgvZakazaniPregledi.CurrentRow.DataBoundItem as pregled;

                ObaviPregledForma obaviPregled = new ObaviPregledForma(pregled);
                obaviPregled.ShowDialog();
                PrikaziPreglede();
                PrikaziZakazanePreglede();
                PrikaziPovijestKilaze(pregled);
                PrikaziPovijestOpsega(pregled);
                PrikaziMjere(pregled);
            }
            else
            {
                MessageBox.Show("Morate odabrati zakazani pregled");
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

        private void dgvPregledi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPregledi.SelectedRows.Count == 1)
            {
                pregled pregled = dgvPregledi.CurrentRow.DataBoundItem as pregled;

                PrikaziPovijestKilaze(pregled);
                PrikaziPovijestOpsega(pregled);
                PrikaziMjere(pregled);
            }
        }
    }


}
