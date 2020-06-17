namespace Console
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            Doctor = new HashSet<Doctor>();
            Patients = new HashSet<Patients>();
        }

        [Key]
        public Guid IdUser { get; set; }

        public int User_Role { get; set; }

        [StringLength(250)]
        public string username { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(250)]
        public string Password { get; set; }

        [StringLength(8)]
        public string DNI { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        [StringLength(1)]
        public string Gener { get; set; }

        public DateTime Date_create { get; set; }

        public DateTime Date_update { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doctor> Doctor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patients> Patients { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
