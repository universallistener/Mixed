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
    
    public partial class TaxOverrideReasonT
    {
        public TaxOverrideReasonT()
        {
            this.TaxJurisdictionTs = new HashSet<TaxJurisdictionT>();
            this.TaxJurisdictionTs1 = new HashSet<TaxJurisdictionT>();
            this.TaxJurisdictionTs2 = new HashSet<TaxJurisdictionT>();
        }
    
        public int TAXOVERRIDEID { get; set; }
        public Nullable<int> TaxID { get; set; }
        public string OVERRIDEREASON { get; set; }
        public Nullable<int> ReleaseNo { get; set; }
    
        public virtual ReleaseT ReleaseT { get; set; }
        public virtual TaxAuthorityTaxT TaxAuthorityTaxT { get; set; }
        public virtual ICollection<TaxJurisdictionT> TaxJurisdictionTs { get; set; }
        public virtual ICollection<TaxJurisdictionT> TaxJurisdictionTs1 { get; set; }
        public virtual ICollection<TaxJurisdictionT> TaxJurisdictionTs2 { get; set; }
    }
}
