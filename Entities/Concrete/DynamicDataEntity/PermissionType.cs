using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DynamicDataEntity
{
    public class PermissionType:IEntity
    {
        [Key]
        public int IzinTurId { get; set; }
        public string IzinTuru { get; set; }
    }
}
