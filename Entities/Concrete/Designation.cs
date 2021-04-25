using Core.Entities;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{    //Atama Bilgisi
    public class Designation:IEntity 
    {
        [Key]
        public int PersonelAtamaId { get; set; }
        public int PersonelKimlikId { get; set; }
        public int IsYeriId { get; set; }
        public int AtamaIstegiNedenId { get; set; }
        public string Aciklama { get; set; }
        public int NakilDurumId { get; set; }
        public DateTime? KatilisTarihi { get; set; }
        public DateTime? AyrilisTarihi { get; set; }
        public int IlgiliGenelMudurOnay { get; set; }
        public int PersonelGenelMudurOnay { get; set; }
        public int IsVerenVekiliOnay { get; set; }

    }
}
