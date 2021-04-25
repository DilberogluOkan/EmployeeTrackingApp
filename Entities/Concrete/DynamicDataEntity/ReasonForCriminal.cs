using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DynamicDataEntity
{
    public class ReasonForCriminal:IEntity
    {
        [Key]
        public int CezaNedenId { get; set; }
        public string CezaNedeni { get; set; }
    }
}
