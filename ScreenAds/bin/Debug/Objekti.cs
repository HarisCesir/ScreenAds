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
    
    public partial class Objekti
    {
        public Objekti()
        {
            this.Televizije = new HashSet<Televizije>();
        }
    
        public int ObjekatID { get; set; }
        public string Adresa { get; set; }
        public string Naziv { get; set; }
        public int TipId { get; set; }
        public string KontaktTelefon { get; set; }
        public string KontaktOsoba { get; set; }
    
        public virtual TipObjekta TipObjekta { get; set; }
        public virtual ICollection<Televizije> Televizije { get; set; }
    }
}
