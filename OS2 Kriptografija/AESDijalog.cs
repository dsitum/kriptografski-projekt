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
using System.IO;

namespace OS2_Kriptografija
{
    public partial class AESDijalog : Form
    {
        private byte[] inicijalizacijskiVektor = null;
        private byte[] kljuc = null;
        private string ucitanaPoruka = null;
        private string procesiranaPoruka = null;
        private bool enkripcija;

        // konstruktor. Argument enkripcija govori radi li se o AES enkripciji ili dekripciji
        public AESDijalog(bool enkripcija)
        {
            InitializeComponent();

            // ako se radi o enkripciji, moramo postaviti sve tekstualne oznake (label-e) na enkripciju
            if (enkripcija)
            {
                tekst_label.Text = "Čisti tekst";
                enkriptirajDekriptiraj_btn.Text = "Enkriptiraj";
            } else
            {
                tekst_label.Text = "Kriptirani tekst";
                enkriptirajDekriptiraj_btn.Text = "Dekriptiraj";
            }
            this.enkripcija = enkripcija;
        }

        private void odaberiIV_Click(object sender, EventArgs e)
        {
            Datoteka odaberiIV_dijalog = new Datoteka("Odaberite inicijalizacijski vektor");
            string sadrzaj = odaberiIV_dijalog.ucitajIzDatoteke();
            if (sadrzaj != null)
            {
                inicijalizacijskiVektor = Convert.FromBase64String(sadrzaj);
                aesIVputanja_textbox.Text = odaberiIV_dijalog.LokacijaDatoteke;
            }
        }

        private void odaberiKljuc_Click(object sender, EventArgs e)
        {
            Datoteka odaberiKljuc_dijalog = new Datoteka("Odaberite AES ključ");
            string sadrzaj = odaberiKljuc_dijalog.ucitajIzDatoteke();
            if (sadrzaj != null)
            {
                kljuc = Convert.FromBase64String(sadrzaj);
                aesKljucPutanja_textbox.Text = odaberiKljuc_dijalog.LokacijaDatoteke;
            }
        }

        private void odaberiTekst_Click(object sender, EventArgs e)
        {
            string naslovDijaloga;
            if (enkripcija)
                naslovDijaloga = "Odaberite kriptirani tekst";
            else
                naslovDijaloga = "Odaberite čisti tekst";

            Datoteka odaberiTekst_dijalog = new Datoteka(naslovDijaloga);
            ucitanaPoruka = odaberiTekst_dijalog.ucitajIzDatoteke();

            if (ucitanaPoruka != null)
            {
                aesPorukaPutanja_textbox.Text = odaberiTekst_dijalog.LokacijaDatoteke;
            }
        }

        private void enkriptirajDekriptiraj_btn_Click(object sender, EventArgs e)
        {
            if (inicijalizacijskiVektor == null || kljuc == null || ucitanaPoruka == null)
            {
                MessageBox.Show("Najprije unesite sve potrebne podatke!");
            } else
            {
                byte[] bajtoviProcesiranePoruke;
                string naslovDijaloga;

                if (enkripcija)
                {
                    bajtoviProcesiranePoruke = Enkriptiraj();
                    naslovDijaloga = "Pohrana kriptiranog teksta";
                    procesiranaPoruka = Convert.ToBase64String(bajtoviProcesiranePoruke);
                }
                else
                {
                    procesiranaPoruka = Dekriptiraj();
                    naslovDijaloga = "Pohrana dekriptiranog teksta";
                }

                Datoteka spremiTekst = new Datoteka(naslovDijaloga);
                spremiTekst.zapisiUDatoteku(procesiranaPoruka);
            }
        }

        private byte[] Enkriptiraj()
        {
            AesManaged aes = new AesManaged();
            aes.IV = inicijalizacijskiVektor;
            aes.Key = kljuc;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform enkriptor = aes.CreateEncryptor();
            MemoryStream memorijskiTok = new MemoryStream();
            CryptoStream kriptografskiTok = new CryptoStream(memorijskiTok, enkriptor, CryptoStreamMode.Write);
            StreamWriter pisacToka = new StreamWriter(kriptografskiTok);
            pisacToka.Write(ucitanaPoruka);
            pisacToka.Close();
            kriptografskiTok.Close();
            byte[] kriptiraniTekst = memorijskiTok.ToArray();
            memorijskiTok.Close();
            return kriptiraniTekst;
        }

        private string Dekriptiraj()
        {
            AesManaged aes = new AesManaged();
            aes.IV = inicijalizacijskiVektor;
            aes.Key = kljuc;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform dekriptor = aes.CreateDecryptor();
            MemoryStream memorijskiTok = new MemoryStream(Convert.FromBase64String(ucitanaPoruka));
            CryptoStream kriptografskiTok = new CryptoStream(memorijskiTok, dekriptor, CryptoStreamMode.Read);
            StreamReader citacToka = new StreamReader(kriptografskiTok);
            string originalniTekst = citacToka.ReadToEnd();
            citacToka.Close();
            kriptografskiTok.Close();
            memorijskiTok.Close();
            return originalniTekst;
        }
    }
}
