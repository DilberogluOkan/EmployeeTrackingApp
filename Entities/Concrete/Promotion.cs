using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{   //Terfi Bilgisi
    public class Promotion:IEntity
    {
        [Key]
        public int PersonelTerfiId { get; set; }
        public int PersonelKimlikId { get; set; }
        public string Derece { get; set; }
        public string Kademe { get; set; }
        public string TerfiTarihi { get; set; }
        public string DegisiklikNedeni { get; set; }
        public string Aciklama { get; set; }
        public virtual Identity Identity { get; set; }

    }
}
