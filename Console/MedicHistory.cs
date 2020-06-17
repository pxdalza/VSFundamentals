namespace Console
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicHistory")]
    public partial class MedicHistory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicHistory()
        {
            MedicHistory_Patient = new HashSet<MedicHistory_Patient>();
        }

        public Guid MedicHistoryId { get; set; }

        public Guid RecipeId { get; set; }

        public string Description { get; set; }

        public Guid? PatiendId { get; set; }

        public decimal? Height { get; set; }

        public decimal? Weight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicHistory_Patient> MedicHistory_Patient { get; set; }

        public virtual Recipes Recipes { get; set; }
    }
}
