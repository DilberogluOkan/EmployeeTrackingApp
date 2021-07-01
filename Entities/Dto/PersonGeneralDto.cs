using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class PersonGeneralDto:IDto
    {
        public int PersonelKimlikId { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SicilNo { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        public DateTime? KatilisTarih { get; set; }
        public string MeslekKol { get; set; }
        public string IsYeri { get; set; }
    }
}
