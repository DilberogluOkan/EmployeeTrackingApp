using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{   //Ödül Bilgisi
    public class Award:IEntity
    {
        [Key]
        public int PersonelOdulId { get; set; }
        public int PersonelKimlikId { get; set; }
        public string OdulVerenRutbe { get; set; }
        public string OdulTaktirBilgi { get; set; }
        public DateTime VerildigiTarih { get; set; }
        public string OdulVerenAmirAdi { get; set; }
        public string OdulVerenAmirRutbe { get; set; }
       
    }
}
