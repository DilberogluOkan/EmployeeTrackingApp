using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{   //Eğitim Bilgisi
    public class Graduation:IEntity
    {
        [Key]
        public int PersonelEgitimId { get; set; }
        public int PersonelKimlikId { get; set; }
        public string OkulTuru { get; set; }
        public string FakulteLiseTur { get; set; }
        public string TahsilDerece { get; set; }
        public string Bolum { get; set; }
        public string OkulAd { get; set; }
        public string MezuniyetDurum { get; set; }
        public virtual Identity Identity { get; set; }

    }
}
