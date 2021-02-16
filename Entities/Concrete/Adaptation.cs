using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   //İntibak Bilgisi
    public class Adaptation:IEntity
    {
        public int IntibakBilgiId { get; set; }
        public int KimlikBilgiId { get; set; }
        public string HizmetinGecYer { get; set; }
        public string HizmetinGecKurum { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string PrimGunSayisi { get; set; }

    }
}
