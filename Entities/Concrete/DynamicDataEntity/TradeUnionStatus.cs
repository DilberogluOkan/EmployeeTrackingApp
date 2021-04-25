using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DynamicDataEntity
{
    public class TradeUnionStatus:IEntity
    {
        [Key]
        public int SendikaDurumId { get; set; }
        public string SendikaDurumu { get; set; }
    }
}
