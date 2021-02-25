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
        public int CalısmaUcretiBilgiId { get; set; }
        public int PersonelKimlikId { get; set; }
        public int UcretTurId { get; set; }
        public int GunlukCalismaSuresiId { get; set; }
        public int UcretDereceId { get; set; }
        public int UcretDerecesineTerfiId { get; set; }

        public PriceType PriceType { get; set; }
        public DailyWorkingTime DailyWorkingTime { get; set; }
        public PriceGrade PriceGrade { get; set; }
        public PriceGradeRise PriceGradeRise { get; set; }

    }
}
