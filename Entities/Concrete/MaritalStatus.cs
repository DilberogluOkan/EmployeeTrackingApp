using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MaritalStatus:IEntity
    {
        [Key]
        public int MedeniHalId { get; set; }
        
        public string MedeniHali { get; set; }
    }
}
