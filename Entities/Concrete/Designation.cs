using Core.Entities;
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
        public string IsYeri { get; set; }
        public string AtamaIstegiDurumu { get; set; }
        public DateTime KatilisTarihi { get; set; }
        public DateTime AyrilisTarihi { get; set; }
        public virtual Identity Identity { get; set; }

    }
}
