namespace Console
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dates
    {
        [Key]
        public int DateId { get; set; }

        public Guid DoctorId { get; set; }

        public Guid PatientId { get; set; }

        public DateTime? Date { get; set; }

        public int? TypeAtentionId { get; set; }

        public virtual Patients Patients { get; set; }

        public virtual Type_Atention Type_Atention { get; set; }
    }
}
