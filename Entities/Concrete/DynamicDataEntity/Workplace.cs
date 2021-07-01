using Core.Entities;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DynamicDataEntity
{
    public class Workplace:IEntity
    {
        [Key]
        public int IsYeriId { get; set; }
        public int GenelMudurlukId { get; set; }
        public string IsYeriAdi { get; set; }
        public string Birimi { get; set; }
        public string Kuvvet { get; set; }
        public string Il { get; set; }
    }
}
