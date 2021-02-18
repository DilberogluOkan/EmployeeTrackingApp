using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EmployeeContext : DbContext
    {

        public virtual DbSet<Identity> Identities { get; set; }
        public virtual DbSet<BirthCertificate> BirthCertificates { get; set; }
        public virtual DbSet<Graduation> Graduations { get; set; }
        public virtual DbSet<Military> Militaries { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Criminal> Criminals { get; set; }
        public virtual DbSet<TemporaryDuty> TemporaryDuties { get; set; }
        public virtual DbSet<Adaptation> Adaptations { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Award> Awards { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }

        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<BloodGroup> BloodGroups { get; set; }
        public virtual DbSet<DisabilityStatus> DisabilityStatuses { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Graduation>()
                 .HasRequired<Identity>(p => p.Identity)
                 .WithMany(g => g.Graduations)
                 .HasForeignKey<int>(p => p.PersonelKimlikId);

            modelBuilder.Entity<Designation>()
                  .HasRequired<Identity>(p => p.Identity)
                  .WithMany(g => g.Designations)
                  .HasForeignKey<int>(p => p.PersonelKimlikId);

            modelBuilder.Entity<Criminal>()
                 .HasRequired<Identity>(p => p.Identity)
                 .WithMany(g => g.Criminals)
                 .HasForeignKey<int>(p => p.PersonelKimlikId);

            modelBuilder.Entity<Promotion>()
                .HasRequired<Identity>(p => p.Identity)
                .WithMany(g => g.Promotions)
                .HasForeignKey<int>(p => p.PersonelKimlikId);

            modelBuilder.Entity<Award>()
                  .HasRequired<Identity>(p => p.Identity)
                  .WithMany(g => g.Awards)
                  .HasForeignKey<int>(p => p.PersonelKimlikId);

            modelBuilder.Entity<Course>()
                 .HasRequired<Identity>(p => p.Identity)
                 .WithMany(g => g.Courses)
                 .HasForeignKey<int>(p => p.PersonelKimlikId);

            modelBuilder.Entity<Permission>()
                 .HasRequired<Identity>(p => p.Identity)
                 .WithMany(g => g.Permissions)
                 .HasForeignKey<int>(p => p.PersonelKimlikId);

            modelBuilder.Entity<Adaptation>()
                  .HasRequired<Identity>(p => p.Identity)
                  .WithMany(g => g.Adaptations)
                  .HasForeignKey<int>(p => p.PersonelKimlikId);

            modelBuilder.Entity<TemporaryDuty>()
                 .HasRequired<Identity>(p => p.Identity)
                 .WithMany(g => g.TemporaryDuties)
                 .HasForeignKey<int>(p => p.PersonelKimlikId);

        }
    }
}
