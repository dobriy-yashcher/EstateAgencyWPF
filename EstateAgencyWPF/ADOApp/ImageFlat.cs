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
    
    public partial class ImageFlat
    {
        public int IdImageFlat { get; set; }
        public int Flat { get; set; }
        public int Image { get; set; }
    
        public virtual Image Image1 { get; set; }
        public virtual Flat Flat1 { get; set; }
    }
}