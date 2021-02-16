using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   //Eğitim Bilgisi
    public class Graduation:IEntity
    {
        public int EgitimBilgiId { get; set; }
        public string OkulAdi { get; set; }
        public string Turu { get; set; }
        public string FakulteLiseTur { get; set; }
        public string TahsilDerece { get; set; }
        public string Bolum { get; set; }

    }
}
