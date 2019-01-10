//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PECOM
{
    using System;
    using System.Collections.Generic;
    
    public partial class ITEMS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ITEMS()
        {
            this.ITEMImages = new HashSet<ITEMImages>();
        }
    
        public int ID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public Nullable<short> UnitsOnOrder { get; set; }
        public Nullable<short> ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string ProductCode { get; set; }
        public string ProductClass { get; set; }
        public string SPECODE { get; set; }
        public string SPECODE1 { get; set; }
        public string SPECODE2 { get; set; }
        public string SPECODE3 { get; set; }
        public string EXP { get; set; }
        public string EXP1 { get; set; }
        public string EXP2 { get; set; }
        public string EXP3 { get; set; }
        public Nullable<System.DateTime> ADDDATE { get; set; }
        public Nullable<System.DateTime> EDITDATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEMImages> ITEMImages { get; set; }
    }
}