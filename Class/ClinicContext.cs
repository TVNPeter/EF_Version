using System;
using System.Data.Entity;
using System.Linq;

namespace EF_Version
{
    public class ClinicContext : DbContext
    {
        public ClinicContext()
            : base("name=ClinicDB")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ClinicContext>());
        }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<PrescriptionDetail> PrescriptionDetails { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PrescriptionDetail>()
                .HasKey(pd => new { pd.PrescriptionID, pd.MedicineID });

            base.OnModelCreating(modelBuilder);
        }
    }
}