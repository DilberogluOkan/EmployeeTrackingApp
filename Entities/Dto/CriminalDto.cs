using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class CriminalDto:IDto
    {
        public int PersonelCezaId { get; set; }
        public int PersonelKimlikId { get; set; }
        public string CezaVerenAmir { get; set; }
        public string VerilenCeza { get; set; }
        public string CezaNedeni { get; set; }
        public DateTime CezaTarihi { get; set; }
        public string CezayiVerenKisiAdi { get; set; }
    }
}
