using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Klase
{
   public class androidUpdate
    {
        public static int? Check()
        {

            return connection.db.UPDATEANDROIDTRENUTNISTATUS().First();
        }
        public static void PromjeniBrojUpdate()
        {
            int? broj = connection.db.UPDATEANDROIDTRENUTNISTATUS().FirstOrDefault();

            connection.db.UpdateAndroidDodaj(broj + 1);

        }
    }
}
