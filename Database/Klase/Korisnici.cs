using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Klase
{
   public class Korisnici
    {
        public static void DodajKorisnika(string username, string uloga, string lozinka,string Adresa,string naziv,int tip,string telefon,string kontaktOsoba)
        {
            string lozinkaSalt =Database.UiHelper.UiHelper.GenerateSalt();
            string lozinkaHash = Database.UiHelper.UiHelper.GenerateHash(lozinka, lozinkaSalt);

            int KorisnikID = Convert.ToInt32(connection.db.DodajKorisnika(username, lozinkaHash, lozinkaSalt, uloga).First());

            connection.db.DodajObjekat(Adresa, naziv, tip, telefon, kontaktOsoba, KorisnikID);

        }
    }
}
