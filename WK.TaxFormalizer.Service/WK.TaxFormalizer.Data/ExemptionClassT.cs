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
    
    public partial class ExemptionClassT
    {
        public int DivisionSurrogate { get; set; }
        public string CLASSCODE { get; set; }
        public string ExemptionClassD { get; set; }
        public string TaxHoliday { get; set; }
    
        public virtual DIVISIONT DIVISIONT { get; set; }
    }
}