﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   //İzin bilgisi
    public class Permission:IEntity
    {
        public int IzinBilgisiId { get; set; }
        public string IzinSekli { get; set; }
        public string IzınSebebi { get; set; }
        public string Borclanma { get; set; }
        public string Yil { get; set; }
        public string Ay { get; set; }
        public string Gun { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string OnayDurumu { get; set; }

    }
}