using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS2_Kriptografija
{
    public partial class SHADijalog : Form
    {
        private byte[] SadrzajDatoteke = null;

        public SHADijalog()
        {
            InitializeComponent();
        }

        private void odaberiDatoteku_btn_Click(object sender, EventArgs e)
        {
            Datoteka odaberiDatoteku_dijalog = new Datoteka("Odaberite datoteku");
            string sadrzaj = odaberiDatoteku_dijalog.ucitajIzDatoteke();
            if (sadrzaj != null)
            {
                SadrzajDatoteke = Encoding.UTF8.GetBytes(sadrzaj);
                shaPutanjaDoDatoteke_textbox.Text = odaberiDatoteku_dijalog.LokacijaDatoteke;
            }
        }

        private void izracunajHash_button_Click(object sender, EventArgs e)
        {
            SHA256Managed shaFunkcija = new SHA256Managed();
            shaFunkcija.ComputeHash(SadrzajDatoteke);

            StringBuilder sbuilder = new StringBuilder();
            foreach (byte b in shaFunkcija.Hash)
            {
                sbuilder.AppendFormat("{0:X2}", b);
            }
            string hash = sbuilder.ToString();
            shaHash_textbox.Text = hash;
        }

        private void pohraniHash_btn_Click(object sender, EventArgs e)
        {
            if (shaHash_textbox.Text == "")
            {
                MessageBox.Show("Najprije izračunajte hash!");
            } else
            {
                Datoteka pohraniHash_dijalog = new Datoteka("Odaberite lokaciju za pohranu Hash-a");
                pohraniHash_dijalog.zapisiUDatoteku(shaHash_textbox.Text);
            }
        }
    }
}
