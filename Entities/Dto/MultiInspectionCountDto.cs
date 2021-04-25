using Core.Entities;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class MultiInspectionCountDto:IDto
    {
        public List<Workplace> Workplace { get; set; }
        public List<WorkplaceCount> Count { get; set; }
    }
}
