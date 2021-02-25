using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PriceGrade:IEntity
    {
        [Key]
        public int UcretDereceId { get; set; }
        public string UcretDerecesi { get; set; }
    }
}
