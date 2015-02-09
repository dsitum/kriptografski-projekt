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
    public partial class RSADijalog : Form
    {
        private bool Enkripcija;
        private string JavniKljuc;
        private byte[] Poruka;

        public RSADijalog(bool enkripcija)
        {
            InitializeComponent();

            // ako se radi o enkripciji, moramo postaviti sve tekstualne oznake (label-e) na enkripciju
            if (enkripcija)
            {
                vrstaKljuca_label.Text = "Javni ključ";
                tekst_label.Text = "Čisti tekst";
                enkriptirajDekriptiraj_btn.Text = "Enkriptiraj";
            }
            else
            {
                vrstaKljuca_label.Text = "Privatni ključ";
                tekst_label.Text = "Kriptirani tekst";
                enkriptirajDekriptiraj_btn.Text = "Dekriptiraj";
            }
            this.Enkripcija = enkripcija;
        }

        private void odaberiKljuc_btn_Click(object sender, EventArgs e)
        {
            string tekst;
            if (Enkripcija)
                tekst = "Odaberite javni ključ za enkripciju";
            else
                tekst = "Odaberite privatni ključ za dekripciju";

            Datoteka odaberiKljuc_dijalog = new Datoteka(tekst);
            JavniKljuc = odaberiKljuc_dijalog.ucitajIzDatoteke();
            if (JavniKljuc != null)
            {
                rsaPutanjaKljuca_textbox.Text = odaberiKljuc_dijalog.LokacijaDatoteke;
            }
        }

        private void odaberiTekst_btn_Click(object sender, EventArgs e)
        {
            string tekst;
            if (Enkripcija)
                tekst = "Odaberite tekst za enkripciju";
            else
                tekst = "Odaberite tekst za dekripciju";

            Datoteka odaberiTekst_dijalog = new Datoteka(tekst);
            string poruka = odaberiTekst_dijalog.ucitajIzDatoteke();

            if (poruka != null)
            {
                // ako se radi o enkripciji, jednostavno ekstraktiramo bajtove. Ako se radi o dekripciji, moramo vratiti poruku iz B64 u obične bajtove
                if (Enkripcija)
                    Poruka = Encoding.UTF8.GetBytes(poruka);
                else
                    Poruka = Convert.FromBase64String(poruka);

                rsaPorukaPutanja_textbox.Text = odaberiTekst_dijalog.LokacijaDatoteke;
            }
        }

        private void enkriptirajDekriptiraj_btn_Click(object sender, EventArgs e)
        {
            if (JavniKljuc == null || Poruka == null)
            {
                MessageBox.Show("Najprije unesite sve potrebne podatke!");
            }
            else
            {
                string naslovDijaloga;
                string procesiranaPoruka;

                if (Enkripcija)
                {
                    procesiranaPoruka = Enkriptiraj();
                    naslovDijaloga = "Pohrana kriptirane poruke";
                }
                else
                {
                    procesiranaPoruka = Dekriptiraj();
                    naslovDijaloga = "Pohrana dekriptirane poruke";
                }

                Datoteka pohraniRezultat_dijalog = new Datoteka(naslovDijaloga);
                pohraniRezultat_dijalog.zapisiUDatoteku(procesiranaPoruka);
            }
        }

        private string Enkriptiraj()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString(JavniKljuc);
            byte[] enkriptiranaPorukaUBajtovima = rsa.Encrypt(Poruka, false);
            string enkriptiranaPoruka = Convert.ToBase64String(enkriptiranaPorukaUBajtovima);
            return enkriptiranaPoruka;
        }

        private string Dekriptiraj()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString(JavniKljuc);
            byte[] dekriptiranaPorukaUBajtovima = rsa.Decrypt(Poruka, false);
            string dekriptiranaPoruka = Encoding.UTF8.GetString(dekriptiranaPorukaUBajtovima);
            return dekriptiranaPoruka;
        }
    }
}
