using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class LanguageName:IEntity
    {
        [Key]
        public int YabanciDilId { get; set; }
        public string YabanciDil { get; set; }
    }
}
