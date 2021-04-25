using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class PersonTradeUnionInfoDto:IDto
    {
        public int PersonelKimlikId { get; set; }
        public int SendikaBilgiId { get; set; }
        public string SendikaDurumu { get; set; }
        public string SendikaAdi { get; set; }
    }
}
