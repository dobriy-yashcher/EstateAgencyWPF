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
    
    public partial class Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Address()
        {
            this.Flat = new HashSet<Flat>();
        }
    
        public int IdAddress { get; set; }
        public int City { get; set; }
        public int Region { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
    
        public virtual City City1 { get; set; }
        public virtual Region Region1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flat> Flat { get; set; }
    }
}
