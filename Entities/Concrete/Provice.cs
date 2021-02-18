using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Province:IEntity

    {
        [Key]
        public int IlId { get; set; }
        public string IlAdi { get; set; }
    }
}
