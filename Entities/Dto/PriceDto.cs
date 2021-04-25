using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class PriceDto:IDto
    {
        public int CalismaUcretBilgiId { get; set; }
        public int PersonelKimlikId { get; set; }
        public string UcretTuru { get; set; }
        public string GunlukCalismaSuresi { get; set; }
        public string UcretDerecesi { get; set; }
        public string UcretDerecesineTerfiNedeni { get; set; }
        public DateTime SonUcretDerecesineYukselmeTarih { get; set; }
    }
}
