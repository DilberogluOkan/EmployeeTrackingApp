using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DynamicDataEntity
{
    public class DisabilityStatus:IEntity
    {
        [Key]
        public int EngelDurumId { get; set; }
        public int PersonelKimlikId { get; set; }
        public int OzelDurumId { get; set; }
        public string EngelDurumu { get; set; }
    }
}
