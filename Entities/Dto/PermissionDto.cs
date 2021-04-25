using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class PermissionDto:IDto
    {
        public int PersonelIzinId { get; set; }
        public int PersonelKimlikId { get; set; }
        public int IzinTurId { get; set; }
        public int IzinNedenId { get; set; }
        public string IzinTuru { get; set; }
        public string IzinNedeni { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

    }
}
