//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalVSFundamentals.UI.Forms.Data
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
