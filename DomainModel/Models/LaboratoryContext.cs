using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DomainModel.Models
{
    public partial class LaboratoryContext : DbContext
    {
        public LaboratoryContext()
            : base("name=LaboratoryContext")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<InsuranceType> InsuranceTypes { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<ReceptionDetail> ReceptionDetails { get; set; }
        public virtual DbSet<ReceptionHeader> ReceptionHeaders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TestCategory> TestCategories { get; set; }
        public virtual DbSet<TestRange> TestRanges { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.ReceptionHeaders)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.ReceptionHeaders)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReceptionHeader>()
                .HasMany(e => e.ReceptionDetails)
                .WithRequired(e => e.ReceptionHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.ReceptionDetails)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.TestRanges)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TestCategory>()
                .HasMany(e => e.Tests)
                .WithRequired(e => e.TestCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Tests)
                .WithRequired(e => e.Unit)
                .WillCascadeOnDelete(false);
        }
    }
}
