using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class ForeignLanguageDto:IDto
    {
        public int YabanciDilBilgiId { get; set; }
        public int PersonelKimlikId { get; set; }
        public int YabanciDilId { get; set; }
        public string YabanciDilAdi { get; set; }
        public string SinavAdi { get; set; }
        public string Puani { get; set; }
        public DateTime? BelgeTarihi { get; set; }
    }
}
