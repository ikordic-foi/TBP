using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_IvaKordic
{
    public partial class RegistracijaForma : Form
    {
        public RegistracijaForma()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            Hide();
            PrijavaForma prijava = new PrijavaForma();
            prijava.ShowDialog();
            Close();
        }

        private void btnRegistracijaDoktora_Click(object sender, EventArgs e)
        {
            string ime = tbIme.Text;
            string prezime = tbPrezime.Text;
            string adresa = tbAdresa.Text;
            string telefon = tbTelefon.Text;
            int uloga = 0;
            RegistracijaDoktora(ime, prezime, adresa, telefon, uloga);

            Hide();
            PrijavaForma prijava = new PrijavaForma();
            prijava.ShowDialog();
            Close();
        }

        private void btnRegistracijaPacijenta_Click(object sender, EventArgs e)
        {
            string ime = tbIme.Text;
            string prezime = tbPrezime.Text;
            string adresa = tbAdresa.Text;
            string telefon = tbTelefon.Text;
            string oib = tbOib.Text;
            float kilaza = float.Parse(tbKilaza.Text);
            DateTime datumRodenja = dtpDatumRodenja.Value.Date;
            int uloga = 1;
            RegistracijaPacijenta(ime, prezime, adresa, telefon, oib, kilaza, datumRodenja, uloga);
            
            Hide();
            PrijavaForma prijava = new PrijavaForma();
            prijava.ShowDialog();
            Close();
        }

        private void RegistracijaDoktora(string ime, string prezime, string adresa, string telefon, int uloga)
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                doktor doktor = new doktor
                {
                    ime = ime,
                    prezime = prezime,
                    adresa = adresa,
                    telefon = telefon,
                    uloga = uloga
                };

                try
                {
                    kontekst.doktor.Add(doktor);
                    kontekst.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Neuspješna registracija");
                }

            }
        }

        private void RegistracijaPacijenta(string ime, string prezime, string adresa, string telefon, string oib, float kilaza, DateTime datumRodenja, int uloga)
        {
            using (var kontekst = new projekt_tbpEntities())
            {
                pacijent pacijent = new pacijent
                {
                    ime = ime,
                    prezime = prezime,
                    adresa = adresa,
                    telefon = telefon,
                    oib = oib,
                    kilaza = kilaza,
                    datum_rodenja = datumRodenja,
                    uloga = uloga
                };

                dijete dijete = new dijete
                {
                    prezime = prezime,
                    majka_id = pacijent.id
                };

                try
                {
                    kontekst.pacijent.Add(pacijent);
                    kontekst.dijete.Add(dijete);
                    kontekst.SaveChanges();
                }
                catch (Exception e)
                {
                    if (e.InnerException.InnerException is PostgresException)
                    {
                        MessageBox.Show(e.InnerException.InnerException.Message);
                    }
                    else
                    {
                        MessageBox.Show("Neuspješna registracija");
                    }
                    
                }
            }
        }
    }
}
