using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DynamicDataEntity
{
    public class DesignationApproval:IEntity
    {
        [Key]
        public int OnayId { get; set; }
        public bool OnayDurumu { get; set; }
        public string OnayDurumValue { get; set; }
    }
}
