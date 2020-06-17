namespace Console
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BloodType> BloodType { get; set; }
        public virtual DbSet<Dates> Dates { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<MedicHistory> MedicHistory { get; set; }
        public virtual DbSet<MedicHistory_Patient> MedicHistory_Patient { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Recipe_Details> Recipe_Details { get; set; }
        public virtual DbSet<Recipes> Recipes { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Type_Atention> Type_Atention { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BloodType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BloodType>()
                .HasMany(e => e.Patients)
                .WithRequired(e => e.BloodType1)
                .HasForeignKey(e => e.BloodType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.CMP)
                .IsUnicode(false);

            modelBuilder.Entity<MedicHistory>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Patients>()
                .Property(e => e.Policy)
                .IsUnicode(false);

            modelBuilder.Entity<Patients>()
                .HasMany(e => e.Dates)
                .WithRequired(e => e.Patients)
                .HasForeignKey(e => e.PatientId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patients>()
                .HasMany(e => e.MedicHistory_Patient)
                .WithOptional(e => e.Patients)
                .HasForeignKey(e => e.PatientId);

            modelBuilder.Entity<Recipe_Details>()
                .Property(e => e.Medicine)
                .IsUnicode(false);

            modelBuilder.Entity<Recipe_Details>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Recipes>()
                .HasMany(e => e.MedicHistory)
                .WithRequired(e => e.Recipes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Roles>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Roles>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Roles)
                .HasForeignKey(e => e.User_Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Speciality>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Speciality>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Type_Atention>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.DNI)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Gener)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Doctor)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.Userid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Patients)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
