using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class WorkingPrice:IEntity
    {
        [Key]
        public int CalismaUcretBilgiId { get; set; }
        public int PersonelKimlikId { get; set; }
        public int UcretTurId { get; set; }
        public int GunlukCalismaSureId { get; set; }
        public string UcretDerece { get; set; }
        public int UcretDerecesineTerfiId { get; set; }
        public DateTime SonUcretDerecesineYukselmeTarih { get; set; }


    }
}
