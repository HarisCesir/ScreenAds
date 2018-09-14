
using ScreenAdsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using static ScreenAdsApi.Models.MarketingInfo;
using System.Web.Mvc;
using ScreenAdsApi.Model;
using Newtonsoft.Json;
using System.Web.Helpers;

namespace ScreenAdsApi.Controllers
{
    public class MarketingController : ApiController
    {


        [System.Web.Http.HttpGet]
        public IEnumerable<object> MarketingGet(string naziv, string username, string lozinka)
        {
            var TimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");

            var Time = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZone);


            try
            {
                Klasa.UpdateError(naziv, Time, "Provjera API");


                SelectErrorUpdateProvjera_Result er = Klasa.SelectErrorUpdateProvjera(naziv, Time, "Provjera API");

                if(er==null)
                {
                    Klasa.InsertError(naziv, Time, "Provjera API");
                }



            }
            catch
            {
                
            }


            

            string u = "goldStandard";
            string lo = "goldenring1204";

            if (u == username && lo == lozinka)
            {

                try
                {
                    TelevizijaByName_Result tv = Klasa.TelevizijaByName(naziv);


                    List<Info_Result> info = connectionn.db.Info(tv.TelevizijaID, DateTime.Now.Date).ToList();



                    var grouped = info.OrderBy(x => x.NazivPaketa).GroupBy(x => x.NazivPaketa)
                         .Select(g => new
                         {
                             Paket = g.Key,
                             Termini = g.Select(termin => new
                             {

                                 termin.Termin

                             }).GroupBy(d => d.Termin).Select(s => s.First()),

                             Video = g.Select(v => new
                             {
                                 v.Video,
                                 v.NazivReklame
                             }).GroupBy(r => r.Video).Select(r => r.First())
                         });


                    

                    return grouped;



                }
                catch
                {
                    return null;
                }


            }
            else
            {
                return null;
            }












        }
        [System.Web.Http.HttpPost]
        [System.Web.Http.HttpGet]
        public void ErrorMarketing(string tv)
        {
            var TimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");

            var Time = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZone);

            Klasa.InsertError(tv, Time, "Error Android");

        }


    }
}