using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Klase
{
   public class PaketiDB
    {
        public static void DodajPaket(string naziv)
        {
            connection.db.DodajPaket(naziv);
        }
        public static List<SviPaketi_Result> SviPaketi()
        {

            List<SviPaketi_Result> paketi= connection.db.SviPaketi().ToList();

            SviPaketi_Result paket = new SviPaketi_Result();
            paket.PaketID = 0;
            paket.Naziv = "Odaberi paket";

            paketi.Insert(0, paket);

            return paketi;

        }
        public static void PaketiTvDodaj(int paketID,int TvID)
        {
            connection.db.DodajPaketiTelevizije(paketID, TvID);
            
        }
        public static void PaketiTerminiDodaj(int paketID,string termin)
        {

            connection.db.DodajPaketiTermini(paketID, termin);
        }
        public static void BrisiPaketPaketiTelevizije(int paketID)
        {
            connection.db.BrisiPaketFromPaketiTelevizije(paketID);
        }
        public static Paketi PaketByNaziv(string Naziv)
        {
            return connection.db.PaketByName(Naziv).FirstOrDefault();
        }
        public static PaketiTelevizije ProvjeraPaketiTelevizije(int PaketID,int TelevizijaID)
        {
            return connection.db.PaketiTelevizijeByPaketIDTelevizijaID(PaketID, TelevizijaID).FirstOrDefault();
        }
        public static PaketiTermini ProvjeraPaketiTermini(int PaketID,string Termin)
        {
            return connection.db.PaketiTerminiProvjera(PaketID, Termin).FirstOrDefault();
        }
        public static void BrisiPaket(int PaketID)
        {
            connection.db.BrisiPaket(PaketID);
        }
        public static List<TerminiByPaket_Result> TerminiByPaket(int paketID)
        {

            return connection.db.TerminiByPaket(paketID).ToList();

        }
    }
}
