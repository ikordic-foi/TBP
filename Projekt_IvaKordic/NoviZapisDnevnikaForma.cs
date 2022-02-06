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
    public partial class NoviZapisDnevnikaForma : Form
    {
        pacijent pacijent;
        public NoviZapisDnevnikaForma(pacijent pacijent)
        {
            InitializeComponent();
            this.pacijent = pacijent;
            lblDatum.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string naslov = tbNaslov.Text;
            string opis = rtbOpis.Text;
            DateTime datum = DateTime.Now.Date;

            using (var kontekst = new projekt_tbpEntities())
            {
                dnevnik dnevnik = new dnevnik
                {
                    datum = datum,
                    naslov = naslov,
                    opis = opis,
                    majka_id = pacijent.id
                };

                try
                {
                    kontekst.dnevnik.Add(dnevnik);
                    kontekst.SaveChanges();
                    Close();
                }
                catch (Exception ex)
                {
                    if (ex.InnerException.InnerException is PostgresException)
                    {
                        MessageBox.Show(ex.InnerException.InnerException.Message);
                    }
                    else
                    {
                        MessageBox.Show("Neuspješno dodavanje novog zahtjeva");
                    }
                }
            }
        }
    }
}
