using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Klase
{
   public class TipoviObjektaDB
    {
        public static void DodajTip(string naziv)
        {
            connection.db.DodajTipObjekta(naziv);
        }
        public static List<TipObjekta> SviTipoviObjekta()
        {
            return connection.db.SviTipoviObjekta().ToList();
        }
        public static List<TipObjekta> SviTipoviCombo()
        {
            List<TipObjekta> tipovi = connection.db.SviTipoviObjekta().ToList();

            TipObjekta tip = new TipObjekta();
            tip.Naziv = "Odaberi tip objekta";
            tip.TipObjektaID = 0;
            tipovi.Insert(0, tip);

            return tipovi;
        }
        public static TipObjekta TipByName(string Naziv)
        {
            return connection.db.TipOBjektaByName(Naziv).FirstOrDefault();
        }
        public static void ObrisiTipObjekta(int TipID)
        {
            connection.db.BrisiTipObjekta(TipID);
        }
    }
}
