using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class PersonWorkplaceDto:IDto
    {
        public int PersonelKimlikId { get; set; }
        public int IsYeriId { get; set; }
        public string IsYeriAdi { get; set; }
        public string Birimi { get; set; }
        public string Kuvvet { get; set; }
        public string IsYeriSicilNu { get; set; }
        public string Il { get; set; }
    }
}
