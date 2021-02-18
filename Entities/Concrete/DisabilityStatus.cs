using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DisabilityStatus:IEntity
    {
        [Key]
        public int OzelDurumId { get; set; }
        [StringLength(8)]
        public string OzelDurumu { get; set; }
    }
}
