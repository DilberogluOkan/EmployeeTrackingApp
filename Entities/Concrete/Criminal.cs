using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{    //Adli-Ceza Bilgi
    public class Criminal:IEntity
    {
        public int CezaBilgiId { get; set; }
        public int KimlikBilgiId { get; set; }
        public string CezayiVerenAmir { get; set; }
        public string VerilenCeza { get; set; }
        public DateTime SucTarihi { get; set; }
        public string CezayiVerenKisiAdi { get; set; }

    }
}
