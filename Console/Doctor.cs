namespace Console
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        public Guid DoctorId { get; set; }

        public Guid Userid { get; set; }

        [StringLength(10)]
        public string CMP { get; set; }

        public int? SpecialityId { get; set; }

        public virtual Speciality Speciality { get; set; }

        public virtual Users Users { get; set; }
    }
}
