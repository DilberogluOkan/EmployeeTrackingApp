using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{    //Kimlik Bilgisi
    public class Identity:IEntity
    {
        [Key]
        public int KimlikId { get; set; }
        //public int AskerlikBilgiId { get; set; }
        //public int NufusBilgiId { get; set; }
        //public int MedeniHalId { get; set; }
        //public int CinsiyetId { get; set; }
        //public int OzelDurumId { get; set; }
        //public int KanGrupId { get; set; }
        //public string TcNo { get; set; }
        public string Adi { get; set; }
        //public string Soyadi { get; set; }
        //public DateTime DogumTarihi { get; set; }
        //public int DogumYeri { get; set; }
        //public string Boy { get; set; }
        //public string Sinif { get; set; }
        //public string Kilo { get; set; }

    }
}
