using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS2_Kriptografija
{
    /**
     * Ova klasa koristi se za generiranje ključeva
     **/
    class Kljucevi
    {
        /*
         * Generira simetrični IV i ključ i pohranjuje ih u datoteku u B64 formatu
         */
        public static void generirajSimetricniKljuc()
        {
            AesManaged aes = new AesManaged();

            aes.GenerateIV();
            string b64Zapis = Convert.ToBase64String(aes.IV);
            Datoteka iv_datoteka = new Datoteka("Pohrana inicijalizacijskog vektora");
            iv_datoteka.zapisiUDatoteku(b64Zapis);

            aes.GenerateKey();
            b64Zapis = Convert.ToBase64String(aes.Key);
            Datoteka kljuc_datoteka = new Datoteka("Pohrana simetricnog kljuca");
            kljuc_datoteka.zapisiUDatoteku(b64Zapis);
        }

        public static void generirajAsimetricneKljuceve()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            Datoteka javniKljuc_datoteka = new Datoteka("Pohrana javnog ključa");
            javniKljuc_datoteka.zapisiUDatoteku(rsa.ToXmlString(false));
            Datoteka privatniKljuc_datoteka = new Datoteka("Pohrana privatnog ključa");
            privatniKljuc_datoteka.zapisiUDatoteku(rsa.ToXmlString(true));
        }
    }
}
