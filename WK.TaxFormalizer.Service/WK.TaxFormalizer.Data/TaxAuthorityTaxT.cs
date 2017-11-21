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
    
    public partial class TaxAuthorityTaxT
    {
        public TaxAuthorityTaxT()
        {
            this.TaxabilityTs = new HashSet<TaxabilityT>();
            this.TaxJurisdictionTs = new HashSet<TaxJurisdictionT>();
            this.TaxOverrideReasonTs = new HashSet<TaxOverrideReasonT>();
            this.TransItemTaxTs = new HashSet<TransItemTaxT>();
            this.TransTaxTs = new HashSet<TransTaxT>();
        }
    
        public int TaxID { get; set; }
        public Nullable<int> EntitySurrogate { get; set; }
        public Nullable<int> TaxAuthorityID { get; set; }
        public string TaxType { get; set; }
        public string TaxCat { get; set; }
        public Nullable<int> ContactID { get; set; }
        public Nullable<int> ReleaseNo { get; set; }
    
        public virtual ENTITYT ENTITYT { get; set; }
        public virtual ReleaseT ReleaseT { get; set; }
        public virtual ICollection<TaxabilityT> TaxabilityTs { get; set; }
        public virtual TaxAuthorityT TaxAuthorityT { get; set; }
        public virtual ICollection<TaxJurisdictionT> TaxJurisdictionTs { get; set; }
        public virtual ICollection<TaxOverrideReasonT> TaxOverrideReasonTs { get; set; }
        public virtual ICollection<TransItemTaxT> TransItemTaxTs { get; set; }
        public virtual ICollection<TransTaxT> TransTaxTs { get; set; }
    }
}