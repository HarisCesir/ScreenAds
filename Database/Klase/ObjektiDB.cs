using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Klase
{
   public class ObjektiDB
    {
        public static void DodajObjekat(string naziv,string adresa,int TipObjektaID,string KontaktOsoba,string KontaktTelefon,int KorisnikID)
        {
            connection.db.DodajObjekat(adresa, naziv, TipObjektaID,KontaktTelefon,KontaktOsoba,KorisnikID);
        }
        public static List<ObjektiSaTipovima_Result> ObjektiSaTipovima()
        {
            return connection.db.ObjektiSaTipovima().ToList();
        }
        public static ObjekatByID_Result ObjekatByID(int ObjekatID)
        {
            return connection.db.ObjekatByID(ObjekatID).FirstOrDefault();
        }
        public static ObjekatByNaziv_Result ObjekatByNaziv(string naziv)
        {
            return connection.db.ObjekatByNaziv(naziv).FirstOrDefault();
        }
        public static void ObrisiObjekat(int objekatID)
        {
            connection.db.BrisiObjekat(objekatID);
        }
        public static void IzmjeniObjekat(string naziv,string adresa,int tipObjekta,int ObjekatID,string KontaktOsoba,string KontaktTelefon)
        {
            connection.db.IzmjeniObjekat(adresa, naziv, tipObjekta, ObjekatID,KontaktTelefon,KontaktOsoba);
        }
        public static List<Objekti> SviObjekti()
        {
            List<Objekti> objekti=connection.db.SviObjekti().ToList();

            Objekti objekat = new Objekti();
            objekat.ObjekatID = 0;
            objekat.Naziv = "Odaberi objekat";
            objekti.Insert(0, objekat);

            return objekti;
        }
    }
}
