using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class IdentityInfoDto:IDto
    {
        public int PersonelKimlikId { get; set; }
        public int IsYeriId { get; set; }
    }
}
