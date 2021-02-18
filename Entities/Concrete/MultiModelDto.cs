using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MultiModelDto:IDto
    {
       
        public Identity Identity { get; set; }
        public Graduation Graduation { get; set; }
        public Promotion Promotion { get; set; }
        public Adaptation Adaptation { get; set; }
        public Permission Permission { get; set; }
        public Designation Designation { get; set; }
        public Award Award { get; set; }
        public Course Course { get; set; }
        public Criminal Criminal { get; set; }
        public BirthCertificate BirthCertificate { get; set; }
        public TemporaryDuty TemporaryDuty { get; set; }
       

    }
}
