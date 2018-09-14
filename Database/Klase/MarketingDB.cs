using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Klase
{
  public class MarketingDB
    {
        public static void DodajMarketing(int paketID,int ReklamaID,DateTime datumOD,DateTime datumDO)
        {
            connection.db.DodajMarketing(paketID, ReklamaID, datumOD, datumDO);
        }
        public static List<MarketingByReklama_Result> MarketingByReklama(int ReklamaID)
        {
            return connection.db.MarketingByReklama(ReklamaID).ToList();
        }
        //public static Marketing MarketingProvjera(int PaketID,int ReklamaID,DateTime DatumOD,DateTime DatumDO)
        //{
        //    return connection.db.MarketingProvjera1(PaketID, ReklamaID, DatumOD, DatumDO);
        //}
        public static int ProvjeraSlobodnih(int PaketID,DateTime dan)
        {

            List<ProvjeraSlobodnihDana_Result> listaZauzetihDana = new List<ProvjeraSlobodnihDana_Result>();

            List<ProvjeraSlobodnihDana_Result> provjera= connection.db.ProvjeraSlobodnihDana(PaketID, dan).ToList();
            int suma = 0;
            foreach(ProvjeraSlobodnihDana_Result p in provjera)
            {
                suma = suma + p.DuzinaReklame;
            }



            return suma;

        }
        public static List<MarketingPoDatumu_Result> MarketingPodatumu(DateTime datum)
        {
            return connection.db.MarketingPoDatumu(datum.Date).ToList();
        }
    }
}
