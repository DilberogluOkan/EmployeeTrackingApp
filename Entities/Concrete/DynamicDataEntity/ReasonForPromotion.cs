﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DynamicDataEntity
{
    public class ReasonForPromotion:IEntity
    {
        [Key]
        public int TerfiNedenId { get; set; }
        public string TerfiNedeni { get; set; }
    }
}
