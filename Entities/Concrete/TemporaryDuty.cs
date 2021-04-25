using Core.Entities;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{    //Geçici Görev Bilgisi
    public class TemporaryDuty:IEntity
    {
        [Key]
        public int PersonelGeciciGorevId { get; set; }
        public int PersonelKimlikId { get; set; }
        public int IsYeriId { get; set; }
        public int GeciciGorevNedenId { get; set; }
        public string GorevYeri { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

      
    }
}
