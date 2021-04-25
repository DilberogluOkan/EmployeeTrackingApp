using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{   //İntibak Bilgisi
    public class Adaptation:IEntity
    {
        [Key]
        public int PersonelIntibakId { get; set; }
        public int PersonelKimlikId { get; set; }
        public string HizmetinGecYer { get; set; }
        public string HizmetinGecKurum { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string PrimGunSayisi { get; set; }
       

    }
}
