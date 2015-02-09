using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS2_Kriptografija
{
    public partial class Pocetna_forma : Form
    {
        public Pocetna_forma()
        {
            InitializeComponent();
        }

        private void generirajSimetrciniKljuc_click(object sender, EventArgs e)
        {
            Kljucevi.generirajSimetricniKljuc();
        }

        private void generirajParAsimetricnihKljuceva_click(object sender, EventArgs e)
        {
            Kljucevi.generirajAsimetricneKljuceve();
        }

        private void AesEnkripcijaDijalog_click(object sender, EventArgs e)
        {
            // argument true označava da se radi o enkripciji
            AESDijalog dijalog = new AESDijalog(true);
            dijalog.Show();
        }

        private void AesDekripcijaDijalog_click(object sender, EventArgs e)
        {
            // argument false označava da se radi o dekripciji
            AESDijalog dijalog = new AESDijalog(false);
            dijalog.Show();
        }

        private void shaHashDijalog_Click(object sender, EventArgs e)
        {
            SHADijalog dijalog = new SHADijalog();
            dijalog.Show();
        }

        private void rsaEnkripcijaDijalog_Click(object sender, EventArgs e)
        {
            RSADijalog dijalog = new RSADijalog(true);
            dijalog.Show();
        }

        private void rsaDekripcijaDijalog_Click(object sender, EventArgs e)
        {
            RSADijalog dijalog = new RSADijalog(false);
            dijalog.Show();
        }

        private void digitalnoPotpisivanjeDijalog_Click(object sender, EventArgs e)
        {
            DigitalniPotpis dijalog = new DigitalniPotpis(false);
            dijalog.Show();
        }

        private void provjeraPotpisaDijalog_Click(object sender, EventArgs e)
        {
            DigitalniPotpis dijalog = new DigitalniPotpis(true);
            dijalog.Show();
        }
    }
}
