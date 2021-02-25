using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Workplace:IEntity
    {
        [Key]
        public int PersonelIsyeriId { get; set; }
     
        public int IstihtamDurumId { get; set; }
        public int VardiyaId { get; set; }
        public int ServisBilgiId { get; set; }

        public string IsyeriAdi { get; set; }
        public string Birimi { get; set; }
        public string Kuvvet { get; set; }
        public string IsYeriSicilNu { get; set; }
        public int Il { get; set; }

        public ShiftInfo ShiftInfo { get; set; }
        public WorkingStatus WorkingStatus { get; set; }
        public ServiceInfo ServiceInfo { get; set; }

    }
}
