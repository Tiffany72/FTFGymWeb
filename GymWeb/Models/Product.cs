//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GymWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Rating { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> CategoryId { get; set; }
    }
}
