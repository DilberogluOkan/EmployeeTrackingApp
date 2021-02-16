using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   //Askerlik Bilgisi
    public class Military:IEntity
    {
        public int AskerlikBilgiId { get; set; }
        public string AskerliktenMuafMi { get; set; }
        public DateTime AskerlikBaslamaTarihi { get; set; }
        public DateTime TerhisTarihi { get; set; }
        public string HizmetSuresi { get; set; }
        public string AskerlikStatu { get; set; }
        public string AskerlikBorclanmaDurumu { get; set; }

    }
}
