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
    
    public partial class TransItemTaxT
    {
        public TransItemTaxT()
        {
            this.TransTaxOnTaxTs = new HashSet<TransTaxOnTaxT>();
        }
    
        public long TransactionID { get; set; }
        public int LineItemID { get; set; }
        public int TaxID { get; set; }
        public int TaxRateID { get; set; }
        public string CONTRIBUTE { get; set; }
        public Nullable<decimal> TaxableAmount { get; set; }
        public Nullable<decimal> ExemptTaxableAmt { get; set; }
        public Nullable<decimal> NonTaxableAmt { get; set; }
        public Nullable<decimal> TaxableQuantity { get; set; }
        public Nullable<decimal> ExemptTaxableQty { get; set; }
        public Nullable<decimal> NonTaxableQty { get; set; }
        public Nullable<decimal> TaxApplied3 { get; set; }
        public Nullable<decimal> FeeApplied3 { get; set; }
        public Nullable<decimal> TaxableTaxAmount3 { get; set; }
        public string CT39zA { get; set; }
        public string Situs { get; set; }
        public string CustomTransInfo { get; set; }
        public string NonTaxReason { get; set; }
        public Nullable<int> CEMCertificateID { get; set; }
        public Nullable<int> PartialRateID { get; set; }
        public Nullable<int> ReducedRateID { get; set; }
        public string RateChangeType { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
    
        public virtual TransItemT TransItemT { get; set; }
        public virtual ICollection<TransTaxOnTaxT> TransTaxOnTaxTs { get; set; }
        public virtual TaxAuthorityTaxT TaxAuthorityTaxT { get; set; }
        public virtual TaxRateT TaxRateT { get; set; }
    }
}
