//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill_Product_Detail
    {
        public string bID { get; set; }
        public string pID { get; set; }
        public Nullable<int> bpPrice { get; set; }
        public Nullable<int> bpQuantity_Product { get; set; }
    
        public virtual BILL BILL { get; set; }
        public virtual Product Product { get; set; }
    }
}