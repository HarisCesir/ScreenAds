//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Korisnici
    {
        public Korisnici()
        {
            this.Objekti = new HashSet<Objekti>();
        }
    
        public int KorisnikID { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public string Uloga { get; set; }
    
        public virtual ICollection<Objekti> Objekti { get; set; }
    }
}
