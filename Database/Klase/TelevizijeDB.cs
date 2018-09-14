using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Klase
{
   public class TelevizijeDB
    {
        public static void DodajTelevizija(string Naziv,int GradID,int ObjekatID)
        {
            connection.db.DodajTeleviziju(Naziv, GradID, ObjekatID);
        }
        public static List<TelevizijeInfo_Result> TelevizijeInfo()
        {
            return connection.db.TelevizijeInfo().ToList();
        }

        public static List<TelevizijeInfo_Result> TelevizijeCombo()
        {
            List<TelevizijeInfo_Result> televizije= connection.db.TelevizijeInfo().ToList();

            TelevizijeInfo_Result tv = new TelevizijeInfo_Result();

            tv.TelevizijaID = 0;
            tv.NazivTelevizije = "Odaberi televiziju";

            televizije.Insert(0, tv);

            return televizije;


        }
        public static TelevizijaByName_Result TelevizijaByName(string naziv)
        {
            return connection.db.TelevizijaByName(naziv).FirstOrDefault();
        }
        public static void BrisiTv(int tvID)
        {
            connection.db.BrisiTeleviziju(tvID);
        }
        public static void IzmjeniTV(int TvID,int GradID,int ObjekatID )
        {
            connection.db.IzmjeniTeleviziju(TvID, GradID, ObjekatID);
        }

       public static List<TelevizijeByPaket_Result> TelevizijeByPaket(int paketID)
        {
            return connection.db.TelevizijeByPaket(paketID).ToList();
        }
        public static List<TerminiByPaket_Result> TerminiByPaket(int paketID)
        {
            return connection.db.TerminiByPaket(paketID).ToList();
        }
        public static void BrisiTerminPaket(int paketID,string termin)
        {
            connection.db.BrisiPaketiTermini(paketID, termin);
        }
        public static void BrisiPaketiTelevizije(int PaketTelevizijaID)
        {
            connection.db.BrisiPaketTelevizija(PaketTelevizijaID);
        }
        public static void ObrisiTvFromPaketiTelevzije(int TelevizijaID)
        {
            connection.db.ObrišiTvFromPaketiTelevizije(TelevizijaID);
        }
        public static void ObrisiTvByObjekat(int ObjekatID)
        {
            connection.db.ObrisiTvByObjekat(ObjekatID);
        }
        public static TelevizijaByID_Result TelevizijaByID(int TelevizijaID)
        {
            return connection.db.TelevizijaByID(TelevizijaID).FirstOrDefault();
        }
    }
}
