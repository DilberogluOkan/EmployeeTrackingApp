using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{    //YabancıDil Bilgisi
    public class ForeignLanguage:IEntity
    {
        [Key]
        public int YabanciDilBilgiId { get; set; }
        public int PersonelKimlikId { get; set; }
        public int YabanciDilId { get; set; }
        public string SinavAdi { get; set; }
        public string Puani { get; set; }
        public DateTime BelgeTarihi { get; set; }
       
    }
}
