using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Klase
{
    public class GradoviDB
    {
        public static void DodajGrad(string naziv)
        {
            connection.db.DodajGrad(naziv);
        }
        public static List<Gradovi> SviGradovi()
        {
            return connection.db.SviGradovi().ToList();
        }
        public static List<Gradovi> SviGradoviCombo()
        {
            List < Gradovi > gradovi = connection.db.SviGradovi().ToList();

            Gradovi grad = new Gradovi();
            grad.GradID = 0;
            grad.Naziv = "Odaberi grad";
            gradovi.Insert(0, grad);

            return gradovi;

        }
        public static void BrisiGrad(int GradID)
        {
            connection.db.BrisiGrad(GradID);
        }
    }
}
