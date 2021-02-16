using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   //Ödül Bilgisi
    public class Award:IEntity
    {
        public int OdulBilgiId { get; set; }
        public int KimlikBilgiId { get; set; }
        public string OdulVerenRutbe { get; set; }
        public string OdulTaktirCinsi { get; set; }
        public DateTime VerildigiTarih { get; set; }
        public string OdulVerenAmirAdı { get; set; }
        public string OdulVerenAmirRutbe { get; set; }
    }
}
