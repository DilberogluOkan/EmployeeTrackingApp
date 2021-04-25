using Core.Entities;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{   //Askerlik Bilgisi
    public class Military:IEntity
    {
        [Key]
        public int PersonelAskerlikId { get; set; }
        public int AskerlikDurumId { get; set; }
        public DateTime? AskerlikBasTarih { get; set; }
        public DateTime? TerhisTarih { get; set; }
        public string HizmetSuresi { get; set; }
        public string Statu { get; set; }
        public string BorclanmaDurumu { get; set; }
        public DateTime? AskerlikSonrasiIseBaslamaTarih { get; set; }

       
    }
}
