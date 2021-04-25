using Entities.Concrete;
using Entities.Concrete.DynamicDataEntity;
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

        public DbSet<Identity> Identities { get; set; }
        public DbSet<BirthCertificate> BirthCertificates { get; set; }
        public DbSet<Graduation> Graduations { get; set; }
        public DbSet<Military> Militaries { get; set; }
        public DbSet<ForeignLanguage> ForeignLanguages { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Criminal> Criminals { get; set; }
        public DbSet<TemporaryDuty> TemporaryDuties { get; set; }
        public DbSet<Adaptation> Adaptations { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<TisJobCode> TisJobCodes { get; set; }
        public DbSet<SgkJobCode> SgkJobCodes { get; set; }
        public DbSet<MilitaryStatus> MilitaryStatus { get; set; }
        public DbSet<LanguageName> LanguageNames { get; set; }

        public DbSet<PrivateStatus> PrivateStatus { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<DisabilityStatus> DisabilityStatus { get; set; }
        public DbSet<MaritalStatus> MaritalStatus { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<AdminStatus> AdminStatus { get; set; }
        public DbSet<DailyWorkingTime> DailyWorkingTimes { get; set; }
        public DbSet<GraduationStatus> GraduationStatus { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }
        public DbSet<PriceGradeRise> PriceGradeRises { get; set; }
        public DbSet<PriceGrade> PriceGrades { get; set; }
        public DbSet<PriceType> PriceTypes { get; set; }
        public DbSet<ReasonForCriminal> ReasonForCriminals { get; set; }
        public DbSet<ReasonForDesignation> ReasonForDesignation { get; set; }
        public DbSet<ReasonForPermission> ReasonForPermissions { get; set; }
        public DbSet<ReasonForPromotion> ReasonForPromotions { get; set; }
        public DbSet<ReasonForTemporaryDuty> ReasonForTemporaryDuties { get; set; }
        public DbSet<ServiceInfo> ServiceInfoes { get; set; }
        public DbSet<ShiftInfo> ShiftInfoes { get; set; }
        public DbSet<WorkingPrice> WorkingPrices { get; set; }
        public DbSet<WorkingStatus> WorkingStatus { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }
        public DbSet<TradeUnionInfo> TradeUnionInfoes { get; set; }
        public DbSet<TradeUnionName> TradeUnionNames { get; set; }
        public DbSet<TradeUnionStatus> TradeUnionStatus { get; set; }
        public DbSet<CurrentStatus> CurrentStatus { get; set; }
        public DbSet<DesignationStatus> DesignationStatus { get; set; }
        public DbSet<DesignationApproval> DesignationApprovals { get; set; }

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
