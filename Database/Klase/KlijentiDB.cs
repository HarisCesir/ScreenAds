using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Klase
{
   public class KlijentiDB
    {
        public static void KlijentiDodaj(string Naziv,string KontaktTelefon,string KontaktOsoba)
        {
            connection.db.DodajKlijent(Naziv, KontaktTelefon, KontaktOsoba);
        }
        public static void BrisiKlijent(int KlijentID)
        {
            connection.db.BrisiKlijent(KlijentID);
        }
        public static List<Klijenti> SviKlijenti()
        {
            return connection.db.SviKlijenti().ToList();
        }

        public static List<Klijenti> SviKlijentiCombo()
        {
            List<Klijenti> klijenti = connection.db.SviKlijenti().ToList();

            Klijenti klijent = new Klijenti();
            klijent.Naziv = "Odaberi klijenta";

            klijenti.Insert(0, klijent);

            return klijenti;
        }
        public static Klijenti KlijentByID(int KlijentId)
        {
            return connection.db.KlijentByID(KlijentId).FirstOrDefault();
        }
    }
}
