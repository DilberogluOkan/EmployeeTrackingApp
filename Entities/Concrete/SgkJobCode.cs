using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class SgkJobCode:IEntity
    {
        [Key]
        public int SgkMeslekKodId { get; set; }
        public string SgkMeslekKodAdi { get; set; }
    }
}
