using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{      //Kurs Bilgisi
    public class Course:IEntity
    {
        [Key]
        public int PersonelKursId { get; set; }
        public int PersonelKimlikId { get; set; }
        public string Turu { get; set; }
        public string Sekli { get; set; }
        public string Konusu { get; set; }
        public string KursSinavAdi { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
       

    }
}
