//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScreenAdsApi.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Klijenti
    {
        public Klijenti()
        {
            this.Reklama = new HashSet<Reklama>();
        }
    
        public int KlijentID { get; set; }
        public string Naziv { get; set; }
        public string KontaktTelefon { get; set; }
        public string KontaktOsoba { get; set; }
    
        public virtual ICollection<Reklama> Reklama { get; set; }
    }
}
