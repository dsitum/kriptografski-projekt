using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace OS2_Kriptografija
{
    public partial class DigitalniPotpis : Form
    {
        private bool ProvjeraPotpisa;
        string Kljuc;
        byte[] Poruka;

        public DigitalniPotpis(bool provjeraPotpisa)
        {
            InitializeComponent();
            if (provjeraPotpisa)
            {
                vrstaKljuca_label.Text = "Javni ključ";
                potpisi_btn.Visible = false;
            }
            else
            {
                vrstaKljuca_label.Text = "Privatni ključ";
                provjeraPotpisa_group.Visible = false;
                this.Height = 180;
            }
            this.ProvjeraPotpisa = provjeraPotpisa;
        }

        private void odaberiKljuc_btn_Click(object sender, EventArgs e)
        {
            string tekst;
            if (ProvjeraPotpisa)
                tekst = "Odaberite javni ključ za provjeru potpisa";
            else
                tekst = "Odaberite privatni ključ za potpisivanje";

            Datoteka odaberiKljuc_dijalog = new Datoteka(tekst);
            Kljuc = odaberiKljuc_dijalog.ucitajIzDatoteke();
            if (Kljuc != null)
            {
                putanjaKljuca_textbox.Text = odaberiKljuc_dijalog.LokacijaDatoteke;
            }
        }

        private void odaberiPoruku_btn_Click(object sender, EventArgs e)
        {
            string tekst;
            if (ProvjeraPotpisa)
                tekst = "Odaberite digitalno potpisanu datoteku";
            else
                tekst = "Odaberite datoteku za potpisivanje";

            Datoteka odaberiDatoteku_dijalog = new Datoteka(tekst);
            string poruka = odaberiDatoteku_dijalog.ucitajIzDatoteke();

            if (poruka != null)
            {
                Poruka = Encoding.UTF8.GetBytes(poruka);

                porukaPutanja_textbox.Text = odaberiDatoteku_dijalog.LokacijaDatoteke;
            }
        }

        private void potpisi_btn_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString(Kljuc);
            byte[] potpis = rsa.SignData(Poruka, CryptoConfig.MapNameToOID("SHA256"));
            string potpisB64 = Convert.ToBase64String(potpis);

            Datoteka pohraniPotpis_dijalog = new Datoteka("Pohrana digitalnog potpisa");
            pohraniPotpis_dijalog.zapisiUDatoteku(potpisB64);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString(Kljuc);

            Datoteka ucitajPotpis_dijalog = new Datoteka("Ucitajte postojeći digitalni potpis");
            string potpisB64 = ucitajPotpis_dijalog.ucitajIzDatoteke();

            byte[] potpis = Convert.FromBase64String(potpisB64);
            bool potpisValjan = rsa.VerifyData(Poruka, CryptoConfig.MapNameToOID("SHA256"), potpis);

            if (potpisValjan)
            {
                valjanostPotpisa_label.ForeColor = Color.Green;
                valjanostPotpisa_label.Text = "Potpis valjan!";
            }
            else
            {
                valjanostPotpisa_label.ForeColor = Color.Red;
                valjanostPotpisa_label.Text = "Potpis nije valjan!";
            }
        }
    }
}
