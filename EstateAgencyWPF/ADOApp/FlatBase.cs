//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstateAgencyWPF.ADOApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlatBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FlatBase()
        {
            this.UserFlatBase = new HashSet<UserFlatBase>();
        }
    
        public int IdFlatBase { get; set; }
        public int Flat { get; set; }
        public int Price { get; set; }
        public int Type { get; set; }
        public bool Available { get; set; }
        public System.DateTime DatePublication { get; set; }
    
        public virtual FlatType FlatType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFlatBase> UserFlatBase { get; set; }
        public virtual Flat Flat1 { get; set; }
    }
}