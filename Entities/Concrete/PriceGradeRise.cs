using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PriceGradeRise:IEntity
    {
        [Key]
        public int UcretDerecesineTerfiId { get; set; }
        public string UcretDerecesineTerfiNedeni { get; set; }
    }
}
