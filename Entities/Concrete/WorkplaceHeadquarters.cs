using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class WorkplaceHeadquarters:IEntity
    {
        [Key]
        public int GenelMudurlukId { get; set; }
        public string GenelMudurluk { get; set; }
    }
}
