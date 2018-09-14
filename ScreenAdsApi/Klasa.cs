using ScreenAdsApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ScreenAdsApi
{
    public class Klasa
    {

        public static TelevizijaByName_Result TelevizijaByName(string naziv)
        {
            return connectionn.db.TelevizijaByName(naziv).FirstOrDefault();
        }
        public static void InsertError(string tv,DateTime vrijeme,string TipErrora)
        {
            connectionn.db.InsertError(tv, vrijeme, TipErrora);
        }
        public static void UpdateError(string tv,DateTime vrijeme,string tiperrora)
        {
            connectionn.db.UpdateError(tv, tiperrora, vrijeme);
        }
        public static SelectErrorUpdateProvjera_Result SelectErrorUpdateProvjera(string tv, DateTime vrijeme, string tiperrora)
        {
            return connectionn.db.SelectErrorUpdateProvjera(tv, vrijeme, tiperrora).FirstOrDefault();
        }
    }
}