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
    
    public partial class Authorization
    {
        public int IdAuthorization { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int User { get; set; }
    
        public virtual User User1 { get; set; }
    }
}