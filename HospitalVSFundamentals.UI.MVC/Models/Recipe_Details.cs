//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalVSFundamentals.UI.MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recipe_Details
    {
        public int RecipeDetailId { get; set; }
        public Nullable<System.Guid> RecipeId { get; set; }
        public string Medicine { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string Description { get; set; }
    
        public virtual Recipes Recipes { get; set; }
    }
}
