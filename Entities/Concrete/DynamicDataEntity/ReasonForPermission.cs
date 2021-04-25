using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DynamicDataEntity
{
    public class ReasonForPermission:IEntity
    {
        [Key]
        public int IzinNedenId { get; set; }
        public string IzinNedeni { get; set; }
    }
}
