using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{   //İzin bilgisi
    public class Permission:IEntity
    {
        [Key]
        public int PersonelIzinId { get; set; }
        public int PersonelKimlikId { get; set; }
        public string IzinSekli { get; set; }
        public string IzinSebebi { get; set; }
        public string Borclanma { get; set; }
        public string Yil { get; set; }
        public string Ay { get; set; }
        public string Gun { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string OnayDurum { get; set; }
        public virtual Identity Identity { get; set; }

    }
}
