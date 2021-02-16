using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{      //Kurs Bilgisi
    public class Course:IEntity
    {
        public int KursBilgiId { get; set; }
        public int KimlikBilgiId { get; set; }
        public string Turu { get; set; }
        public string Sekli { get; set; }
        public string Konusu { get; set; }
        public string KursSinavAdi { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

    }
}
