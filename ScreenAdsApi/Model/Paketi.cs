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
    
    public partial class Paketi
    {
        public Paketi()
        {
            this.Marketing = new HashSet<Marketing>();
            this.PaketiTelevizije = new HashSet<PaketiTelevizije>();
            this.PaketiTermini = new HashSet<PaketiTermini>();
        }
    
        public int PaketID { get; set; }
        public string Naziv { get; set; }
    
        public virtual ICollection<Marketing> Marketing { get; set; }
        public virtual ICollection<PaketiTelevizije> PaketiTelevizije { get; set; }
        public virtual ICollection<PaketiTermini> PaketiTermini { get; set; }
    }
}
