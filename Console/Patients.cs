namespace Console
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Patients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patients()
        {
            Dates = new HashSet<Dates>();
            MedicHistory_Patient = new HashSet<MedicHistory_Patient>();
        }

        [Key]
        public Guid PacienteId { get; set; }

        public Guid UserId { get; set; }

        public int BloodType { get; set; }

        [StringLength(50)]
        public string Policy { get; set; }

        public DateTime? Date_Creation { get; set; }

        public DateTime? Date_Update { get; set; }

        public virtual BloodType BloodType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dates> Dates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicHistory_Patient> MedicHistory_Patient { get; set; }

        public virtual Users Users { get; set; }
    }
}
