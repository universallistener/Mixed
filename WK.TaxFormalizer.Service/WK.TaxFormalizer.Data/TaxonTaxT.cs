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
    
    public partial class TaxonTaxT
    {
        public int BoundaryID { get; set; }
        public string BaseTaxType { get; set; }
        public string BaseTaxCat { get; set; }
        public string TaxType { get; set; }
        public string TaxCat { get; set; }
        public System.DateTime LEGALEFFECTIVEDATE { get; set; }
        public int ReleaseNo { get; set; }
        public Nullable<System.DateTime> LEGALEXPIRATIONDATE { get; set; }
        public string TAXABLE { get; set; }
    
        public virtual ReleaseT ReleaseT { get; set; }
    }
}