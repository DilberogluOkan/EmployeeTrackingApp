using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TisJobCode:IEntity
    {
        [Key]
        public string TisMeslekKodId { get; set; }
        public string TisMeslekAdi { get; set; }
    }
}
