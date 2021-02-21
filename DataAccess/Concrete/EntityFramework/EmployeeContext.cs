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

        public  DbSet<Identity> Identities { get; set; }
        public DbSet<BirthCertificate> BirthCertificates { get; set; }
        public  DbSet<Graduation> Graduations { get; set; }
        public  DbSet<Military> Militaries { get; set; }
        public  DbSet<Designation> Designations { get; set; }
        public  DbSet<Criminal> Criminals { get; set; }
        public  DbSet<TemporaryDuty> TemporaryDuties { get; set; }
        public  DbSet<Adaptation> Adaptations { get; set; }
        public  DbSet<Permission> Permissions { get; set; }
        public  DbSet<Course> Courses { get; set; }
        public  DbSet<Award> Awards { get; set; }
        public  DbSet<Promotion> Promotions { get; set; }

        public DbSet<Gender> Genders { get; set; }
        public  DbSet<BloodGroup> BloodGroups { get; set; }
        public  DbSet<DisabilityStatus> DisabilityStatuses { get; set; }
        public  DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public  DbSet<Province> Provinces { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Graduation>()
        //         .HasRequired<Identity>(p => p.Identity)
        //         .WithMany(g => g.Graduations)
        //         .HasForeignKey<int>(p => p.PersonelKimlikId);

        //    modelBuilder.Entity<Designation>()
        //          .HasRequired<Identity>(p => p.Identity)
        //          .WithMany(g => g.Designations)
        //          .HasForeignKey<int>(p => p.PersonelKimlikId);

        //    modelBuilder.Entity<Criminal>()
        //         .HasRequired<Identity>(p => p.Identity)
        //         .WithMany(g => g.Criminals)
        //         .HasForeignKey<int>(p => p.PersonelKimlikId);

        //    modelBuilder.Entity<Promotion>()
        //        .HasRequired<Identity>(p => p.Identity)
        //        .WithMany(g => g.Promotions)
        //        .HasForeignKey<int>(p => p.PersonelKimlikId);

        //    modelBuilder.Entity<Award>()
        //          .HasRequired<Identity>(p => p.Identity)
        //          .WithMany(g => g.Awards)
        //          .HasForeignKey<int>(p => p.PersonelKimlikId);

        //    modelBuilder.Entity<Course>()
        //         .HasRequired<Identity>(p => p.Identity)
        //         .WithMany(g => g.Courses)
        //         .HasForeignKey<int>(p => p.PersonelKimlikId);

        //    modelBuilder.Entity<Permission>()
        //         .HasRequired<Identity>(p => p.Identity)
        //         .WithMany(g => g.Permissions)
        //         .HasForeignKey<int>(p => p.PersonelKimlikId);

        //    modelBuilder.Entity<Adaptation>()
        //          .HasRequired<Identity>(p => p.Identity)
        //          .WithMany(g => g.Adaptations)
        //          .HasForeignKey<int>(p => p.PersonelKimlikId);

        //    modelBuilder.Entity<TemporaryDuty>()
        //         .HasRequired<Identity>(p => p.Identity)
        //         .WithMany(g => g.TemporaryDuties)
        //         .HasForeignKey<int>(p => p.PersonelKimlikId);

        //}
    }
}
