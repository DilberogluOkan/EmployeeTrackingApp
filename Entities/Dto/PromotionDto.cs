using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class PromotionDto:IDto
    {
        public int PersonelKimlikId { get; set; }
        public int PersonelTerfiId { get; set; }
        public string Derece { get; set; }

        public string TerfiTarihi { get; set; }
        public string TerfiNedeni { get; set; }
        public string Aciklama { get; set; }
    }
}
