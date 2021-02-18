using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BloodGroup:IEntity
    {
        [Key]
        public int KanGrupId { get; set; }
        [StringLength(7)]
        public string KanGrubu { get; set; }
    }
}
