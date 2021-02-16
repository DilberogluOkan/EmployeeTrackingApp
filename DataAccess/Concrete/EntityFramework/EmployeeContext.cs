using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EmployeeContext:DbContext
    {
        
        public DbSet<Identity> Identities { get; set; }
        //public virtual DbSet<Adaptation> Adaptations { get; set; }
        //public virtual DbSet<Award> Awards { get; set; }
        //public virtual DbSet<BirthCertificate> BirthCertificates { get; set; }
        //public virtual DbSet<Course> Courses { get; set; }
        //public virtual DbSet<Criminal> Criminals { get; set; }
        //public virtual DbSet<Designation> Designations { get; set; }
        //public virtual DbSet<ForeignLanguage> ForeignLanguages { get; set; }
        //public virtual DbSet<Graduation> EgitimBilgs { get; set; }
        //public virtual DbSet<Military> AskerlikBilgs { get; set; }
        //public virtual DbSet<Permission> IzinBilgs { get; set; }
        //public virtual DbSet<Promotion> TerfiBilgs { get; set; }
        //public virtual DbSet<TemporaryDutyDal> GeciciBilgs { get; set; }
       
    }
}
