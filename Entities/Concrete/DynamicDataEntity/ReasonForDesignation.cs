using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DynamicDataEntity
{
    public class ReasonForDesignation:IEntity
    {
        [Key]
        public int AtamaIstegiNedenId { get; set; }
        public string AtamaIstegiNedeni { get; set; }
    }
}
