using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class TemporaryDutyDto:IDto
    {
        public int PersonelGeciciGorevId { get; set; }
        public int PersonelKimlikId { get; set; }
        public string IsYeriAdi { get; set; }
        public string GeciciGorevNedeni { get; set; }
        public string GorevYeri { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
    }
}
