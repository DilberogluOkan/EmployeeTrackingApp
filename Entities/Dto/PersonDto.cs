using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class PersonDto:IDto
    {
        public int PersonelKimlikId { get; set; }
        public string TcNo { get; set; }
        public string  Adi { get; set; }
        public string Soyadi { get; set; }
        public string CalistigiKurum { get; set; }
        public string IsYeriAdi { get; set; }
        public string MeslekKol { get; set; }
    }
}
