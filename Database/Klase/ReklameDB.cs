using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Klase
{
   public class ReklameDB
    {
        public static void DodajReklamu(string video,string naziv,int KlijentID,int duzina)
        {
            connection.db.DodajReklamu(naziv, video, KlijentID,duzina);
        }
        public static List<SveReklame_Result> SveReklame()
        {
            return connection.db.SveReklame().ToList();
        }

        public static List<SveReklame_Result> SveReklameCombo()
        {
            List<SveReklame_Result> reklame = connection.db.SveReklame().ToList();

            SveReklame_Result reklama = new SveReklame_Result();
            reklama.Naziv = "Odaberi reklamu";

            reklame.Insert(0, reklama);

            return reklame;

        }
        public static void BrisiReklamu(int reklamaID)
        {

            connection.db.BrisiReklamu(reklamaID);
        }
        public static ReklamaByID_Result ReklamaByID(int ReklamaID)
        {
            return connection.db.ReklamaByID(ReklamaID).FirstOrDefault();
        }

        public static void IzmjeniReklamu(string naziv,int KlijentID,int reklamaID,string video)
        {
            connection.db.IzmjeniReklamu(reklamaID, naziv, KlijentID,video);
        }
        public static List<Reklama> ReklamaByKlijent(int KlijentID)
        {
            return connection.db.ReklameByKlijent(KlijentID).ToList();
        }
        public static Reklama ReklamaByNaziv(string Naziv)
        {
            return connection.db.ReklamaByNaziv(Naziv).FirstOrDefault();
        }
        public static List<ReklameByPaketIDatum_Result> ReklameByPaketDatum(int PaketID,DateTime datum)
        {
            return connection.db.ReklameByPaketIDatum(PaketID, datum).ToList();
        }
    }
}
