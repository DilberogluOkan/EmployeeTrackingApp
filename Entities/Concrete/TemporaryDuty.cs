using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{    //Geçici Görev Bilgisi
    public class TemporaryDuty:IEntity
    {
        public int GeciciGorevBilgiId { get; set; }
        public string GorevlendirildigiBirlik { get; set; }
        public string GorevYeri { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

    }
}
