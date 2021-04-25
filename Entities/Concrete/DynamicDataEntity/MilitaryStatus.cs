using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DynamicDataEntity
{
    public class MilitaryStatus:IEntity
    {
        [Key]
        public int AskerlikDurumId { get; set; }
        public string AskerlikDurumu { get; set; }
    }
}
