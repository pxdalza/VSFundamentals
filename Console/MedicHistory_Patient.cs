namespace Console
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MedicHistory_Patient
    {
        [Key]
        [Column("MedicHistory_Patient")]
        public int MedicHistory_Patient1 { get; set; }

        public Guid? PatientId { get; set; }

        public Guid? MedicHistoryId { get; set; }

        public virtual MedicHistory MedicHistory { get; set; }

        public virtual Patients Patients { get; set; }
    }
}
