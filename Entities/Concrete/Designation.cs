using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{    //Atama Bilgisi
    public class Designation:IEntity 
    {
        public int AtamaBilgiId { get; set; }
        public int KimlikBilgiId { get; set; }
        public string IsYeri { get; set; }
        public string AtamaIstegiDurumu  { get; set; }
        public DateTime KatilisTarihi { get; set; }
        public DateTime AyrilisTarihi { get; set; }

    }
}
