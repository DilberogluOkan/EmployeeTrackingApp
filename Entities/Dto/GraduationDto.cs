using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class GraduationDto:IDto
    {
        public int PersonelEgitimId { get; set; }
        public int PersonelKimlikId { get; set; }
        public string EgitimDurumu { get; set; }
        public string OkulTuru { get; set; }
        public string FakulteLiseTur { get; set; }
        public string TahsilDerece { get; set; }
        public string Bolum { get; set; }
        public string OkulAd { get; set; }
    }
}
