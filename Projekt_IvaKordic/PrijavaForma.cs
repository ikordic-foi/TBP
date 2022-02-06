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
    public partial class PrijavaForma : Form
    {
        public PrijavaForma()
        {
            InitializeComponent();
        }

        private void btnPrijavaPacijenta_Click(object sender, EventArgs e)
        {
            string ime = tbIme.Text;
            string prezime = tbPrezime.Text;
            PrijavaPacijenta(ime, prezime);
        }

        private void btnPrijavaDoktora_Click(object sender, EventArgs e)
        {
            string ime = tbIme.Text;
            string prezime = tbPrezime.Text;
            PrijavaDoktora(ime, prezime);
        }

        private void PrijavaDoktora(string ime, string prezime)
        {
            using(var kontekst = new projekt_tbpEntities())
            {
                var query = from korisnik in kontekst.doktor
                            where korisnik.ime == ime
                            && korisnik.prezime == prezime
                            && korisnik.uloga == 0
                            select korisnik;

                doktor doktor = null;

                try
                {
                    doktor = query.First();
                }
                catch (Exception)
                {
                    MessageBox.Show("Doktor ne postoji");
                }

                if (doktor != null)
                {
                    Hide();
                    GlavnaFormaDoktor glavnaFormaDoktor = new GlavnaFormaDoktor(doktor);
                    glavnaFormaDoktor.ShowDialog();
                    Close();
                }
            }
        }

        private void PrijavaPacijenta(string ime, string prezime)
        {
            pacijent pacijent = null;

            using (var kontekst = new projekt_tbpEntities())
            {
                var query = from korisnik in kontekst.pacijent
                            where korisnik.ime == ime
                            && korisnik.prezime == prezime
                            && korisnik.uloga == 1
                            select korisnik;

                try
                {
                    pacijent = query.First();
                }
                catch (Exception)
                {
                    MessageBox.Show("Pacijent ne postoji");
                }
            }

            if (pacijent != null)
            {
                Hide();
                GlavnaFormaPacijent glavnaFormaPacijent = new GlavnaFormaPacijent(pacijent);
                glavnaFormaPacijent.ShowDialog();
                Close();
            }
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Hide();
            RegistracijaForma registracija = new RegistracijaForma();
            registracija.ShowDialog();
            Close();
        }
    }
}
