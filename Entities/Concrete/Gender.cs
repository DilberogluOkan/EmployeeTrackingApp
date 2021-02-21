using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Gender:IEntity
    {
        [Key]
        public int CinsiyetId { get; set; }
        [StringLength(5)]
        public string Cinsiyeti { get; set; }

        
    }
}
