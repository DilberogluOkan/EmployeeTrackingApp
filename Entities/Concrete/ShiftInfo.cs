using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ShiftInfo:IEntity
    {
        [Key]
        public int VardiyaBilgiId { get; set; }
        public string VardiyaBilgisi  { get; set; }
    }
}
