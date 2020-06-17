namespace Console
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Recipe_Details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecipeDetailId { get; set; }

        public Guid? RecipeId { get; set; }

        [StringLength(250)]
        public string Medicine { get; set; }

        public decimal? Quantity { get; set; }

        public string Description { get; set; }

        public virtual Recipes Recipes { get; set; }
    }
}
