using Core.Entities;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{   //İzin bilgisi
    public class Permission:IEntity
    {
        [Key]
        public int PersonelIzinId { get; set; }
        public int PersonelKimlikId { get; set; }
        public int IzinTurId { get; set; }
        public int IzinNedenId { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

      
       
    }
}
