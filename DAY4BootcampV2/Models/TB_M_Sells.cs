//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAY4BootcampV2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_M_Sells
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_M_Sells()
        {
            this.TB_T_TransactionItems = new HashSet<TB_T_TransactionItems>();
        }
    
        public int Id { get; set; }
        public System.DateTime OrderDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_T_TransactionItems> TB_T_TransactionItems { get; set; }
    }
}