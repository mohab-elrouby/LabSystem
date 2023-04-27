using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Data
{
    public class LabContext : DbContext
    {
        public LabContext() : base("DefaultConnection")
        {
        }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<TestPatient> TestPatients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestPatient>().HasRequired(i => i.test).WithMany(i => i.PaitentTests).HasForeignKey(i => i.TestId);
            modelBuilder.Entity<TestPatient>().HasRequired(i => i.Patient).WithMany(i => i.PaitentTests).HasForeignKey(i => i.PatientId);
        }
    }
}
