using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   //Terfi Bilgisi
    public class Promotion:IEntity
    {
        public int TerfiBilgiId { get; set; }
        public int KimlikBilgiId { get; set; }
        public string Derece { get; set; }
        public string Kademe { get; set; }
        public DateTime TerfiTarih { get; set; }
        public string DegisiklikNedeni { get; set; }
        public string Aciklama { get; set; }

    }
}
