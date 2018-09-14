using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Klase
{
    public class errorAndroid
    {
        public static List<SelectError_Result> SelectProvjeraApi()
        {
            List<SelectError_Result> lista = connection.db.SelectError().ToList();

            List<SelectError_Result> Provjera = new List<SelectError_Result>();


            foreach(SelectError_Result a in lista)
            {
                if(a.TipErrora=="Provjera API")
                {
                    Provjera.Add(a);
                }
            }

            return Provjera;
        }

        public static List<SelectError_Result> SelectErrorAndroid()
        {
            List<SelectError_Result> lista = connection.db.SelectError().ToList();

            List<SelectError_Result> Provjera = new List<SelectError_Result>();


            foreach (SelectError_Result a in lista)
            {
                if (a.TipErrora == "Error Android")
                {
                    Provjera.Add(a);
                }
            }

            return Provjera;
        }
        public static void BrisiError(int errorID)
        {
            connection.db.DeleteError(errorID);
        }
        public static List<SelectError_Result> SelectProvjera2SataCheck()
        {
            List<SelectError_Result> lista = connection.db.SelectError().ToList();

            List<SelectError_Result> Provjera = new List<SelectError_Result>();
            List<SelectError_Result> ProvjeraEror = new List<SelectError_Result>();

            foreach (SelectError_Result a in lista)
            {
                if (a.TipErrora == "Provjera API")
                {
                    Provjera.Add(a);
                }
            }

            foreach(SelectError_Result a in Provjera)
            {
                if (a.Vrijeme < DateTime.Now.AddHours(-2))
                    {

                    ProvjeraEror.Add(a);
                }
            }


            return ProvjeraEror;
        }
    }
}
