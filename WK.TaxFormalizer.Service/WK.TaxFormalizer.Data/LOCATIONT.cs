//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WK.TaxFormalizer.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOCATIONT
    {
        public int LocationSurrogate { get; set; }
        public Nullable<int> DivisionSurrogate { get; set; }
        public Nullable<int> GeoID { get; set; }
        public string LocationID { get; set; }
        public Nullable<int> AddressID { get; set; }
        public string LocationDesc { get; set; }
        public string OverrideGeoID { get; set; }
        public Nullable<System.DateTime> CustomerEffectiveDate { get; set; }
        public string DefaultLocation { get; set; }
    }
}
