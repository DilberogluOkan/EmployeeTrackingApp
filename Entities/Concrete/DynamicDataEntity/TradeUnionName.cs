using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DynamicDataEntity
{
    public class TradeUnionName:IEntity
    {
        [Key]
        public int SendikaAdId { get; set; }
        public string SendikaAdi { get; set; }
    }
}
