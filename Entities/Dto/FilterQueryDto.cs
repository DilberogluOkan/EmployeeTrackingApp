using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities.Dto
{
    public class FilterQueryDto:IDto
    {
        public int PersonelKimlikId { get; set; }
        public int IsYeriId { get; set; }
        public int GenelMudurlukId { get; set; }
        public string GenelMudurluk { get; set; }
        public string Kuvvet { get; set; }
        public string IsYeriAdi { get; set; }
        public string Birimi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public string UcretTuru { get; set; }
        public int UcretTurId { get; set; }
        public string MeslekKol { get; set; }
        public int MeslekKolId { get; set; }
        public DateTime? KatilisTarihi { get; set; }
        public DateTime? KatilisTarihi1 { get; set; }
        public DateTime? KatilisTarihi2 { get; set; }
        public int IdarecilikId { get; set; }
        public string IdarecilikDurumu { get; set; }
        public int GunlukCalismaSureId { get; set; }
        public string GunlukCalismaSuresi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public DateTime? DogumTarihiBaslangic { get; set; }
        public DateTime? DogumTarihiBitis { get; set; }

        public int EngelDurumId { get; set; }
        public string EngelDurumu { get; set; }
        public int MedeniHalId { get; set; }
        public string MedeniHali { get; set; }
        public int CinsiyetId { get; set; }
        public string Cinsiyeti { get; set; }
        public int IstihtamDurumId { get; set; }
        public string IstihtamDurumu { get; set; }


    }
}
