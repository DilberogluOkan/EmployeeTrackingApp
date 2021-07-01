using Core.Entities;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class DesignationDto:IDto
    {
        public int PersonelAtamaId { get; set; }
        public int PersonelKimlikId { get; set; }
        public int IsYeriId { get; set; }
        public int GenelMudurlukId { get; set; }
        public string GenelMudurluk { get; set; }
        public int AtamaIstegiNedenId { get; set; }
        public string IsYeriAdi { get; set; }
        public string AtamaIstegiNedeni { get; set; }
        public string Aciklama { get; set; }
        public string NakilDurum { get; set; }
        public DateTime? KatilisTarihi { get; set; }
        public DateTime? AyrilisTarihi { get; set; }
        public DateTime? NakilTalepTarihi { get; set; }
        public bool IlgiliGenelMudurOnay { get; set; }
        public bool PersonelGenelMudurOnay { get; set; }
        public bool IsVerenVekiliOnay { get; set; }

    }
}
