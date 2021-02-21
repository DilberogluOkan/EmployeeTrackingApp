using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MultiModelReportDto:IDto
    {
        public List<Identity> Identity { get; set; }
        public List<Graduation> Graduation { get; set; }
        public List<Promotion> Promotion { get; set; }
        public List<Adaptation> Adaptation { get; set; }
        public List<Permission> Permission { get; set; }
        public List<Designation> Designation { get; set; }
        public List<Award> Award { get; set; }
        public List<Course> Course { get; set; }
        public List<Criminal> Criminal { get; set; }
        public BirthCertificate BirthCertificate { get; set; }
        public List<TemporaryDuty> TemporaryDuty { get; set; }
    }
}
