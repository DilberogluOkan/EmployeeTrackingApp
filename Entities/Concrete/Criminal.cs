using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{    //Adli-Ceza Bilgi
    public class Criminal:IEntity
    {
        [Key]
        public int PersonelCezaId { get; set; }
        public int PersonelKimlikId { get; set; }
        public string CezaVerenAmir { get; set; }
        public string VerilenCeza { get; set; }
        public DateTime SucTarihi { get; set; }
        public string CezayiVerenKisiAdi { get; set; }
        public virtual Identity Identity { get; set; }

    }
}
