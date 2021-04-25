using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ServiceInfo:IEntity
    {
        [Key]
        public int ServisBilgiId { get; set; }
        public string ServisBilgisi { get; set; }
    }
}
