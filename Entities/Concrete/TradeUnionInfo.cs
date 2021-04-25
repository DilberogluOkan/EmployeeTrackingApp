using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TradeUnionInfo:IEntity
    {
        [Key]
        public int SendikaBilgiId { get; set; }
        public int SendikaDurumId { get; set; }
        public int SendikaAdId { get; set; }

    }
}
