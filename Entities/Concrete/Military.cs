using Core.Entities;
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
        public bool AskerliktenMuafMi { get; set; }

        [DataType(DataType.Date)]
        public DateTime AskerlikBasTarih { get; set; }

        [DataType(DataType.Date)]
        public DateTime TerhisTarih { get; set; }

        public string HizmetSuresi { get; set; }

        public string Statu { get; set; }

        public string BorclanmaDurumu { get; set; }
        

    }
}
