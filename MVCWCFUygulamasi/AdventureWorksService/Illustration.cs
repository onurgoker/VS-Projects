//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorksService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Illustration
    {
        public Illustration()
        {
            this.ProductModelIllustration = new HashSet<ProductModelIllustration>();
        }
    
        public int IllustrationID { get; set; }
        public string Diagram { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ProductModelIllustration> ProductModelIllustration { get; set; }
    }
}