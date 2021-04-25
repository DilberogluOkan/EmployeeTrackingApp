using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DynamicDataEntity
{
    public class WorkingStatus:IEntity
    {
        [Key]
        public int IstihtamDurumId { get; set; }
        public string IstihtamDurumu { get; set; }
    }
}
