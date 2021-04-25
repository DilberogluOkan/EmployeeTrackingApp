using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PriceType:IEntity
    {
        [Key]
        public int UcretTurId { get; set; }
        public string UcretTuru { get; set; }

     

    }
}
