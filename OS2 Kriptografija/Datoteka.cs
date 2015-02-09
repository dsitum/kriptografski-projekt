using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS2_Kriptografija
{
    class Datoteka
    {
        public string NaslovDijaloga = null;
        private string _lokacijaDatoteke;
        public string LokacijaDatoteke { 
            get { return _lokacijaDatoteke; }
        }

        // konstruktor bez argumenata
        public Datoteka()
        {

        }

        // konstruktor s argumentom za naziv dijaloga za učitavanje/pohranu datoteke
        public Datoteka(string naslovDijaloga)
        {
            this.NaslovDijaloga = naslovDijaloga;
        }


        /*
         * Otvara "Save as" dijalog i sprema dani zapis u datoteku
         * po odabiru korisnika.
         */
        public void zapisiUDatoteku(string tekst)
        {
            SaveFileDialog pohraniDijalog = new SaveFileDialog();
            pohraniDijalog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            pohraniDijalog.Filter = "Tekst|*.txt";
            if (NaslovDijaloga != null)
                pohraniDijalog.Title = NaslovDijaloga;

            if (pohraniDijalog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(pohraniDijalog.FileName, tekst);
                _lokacijaDatoteke = pohraniDijalog.FileName;
            }
        }

        /*
         * Otvara "Open file" dijalog i učitava tekst iz datoteke 
         * te ga vraća u obliku bajtova
         */
        public string ucitajIzDatoteke()
        {
            OpenFileDialog ucitajDijalog = new OpenFileDialog();
            ucitajDijalog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ucitajDijalog.Filter = "Tekst|*.txt";
            if (NaslovDijaloga != null)
                ucitajDijalog.Title = NaslovDijaloga;


            string sadrzaj = null;

            if (ucitajDijalog.ShowDialog() == DialogResult.OK)
            {
                sadrzaj = System.IO.File.ReadAllText(ucitajDijalog.FileName);
                _lokacijaDatoteke = ucitajDijalog.FileName;
            }
            
            return sadrzaj;
        }
    }
}
