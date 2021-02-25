using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DailyWorkingTime:IEntity
    {
        [Key]
        public int GunlukCalismaSureId { get; set; }
        public string GunlukCalismaSuresi { get; set; }
    }
}
