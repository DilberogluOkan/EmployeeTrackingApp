using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DynamicDataEntity
{
   public class CurrentStatus:IEntity
    {
        [Key]
        public int MevcutStatuId { get; set; }
        public string MevcutStatu { get; set; }
    }
}
