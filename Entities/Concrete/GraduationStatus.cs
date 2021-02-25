using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class GraduationStatus:IEntity
    {
        [Key]
        public int EgitimDurumId { get; set; }
        public string EgitimDurumu { get; set; }
    }
}
