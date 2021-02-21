using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PersonDto:IDto
    {
        public int PersonelKimlikId { get; set; }
        public string Cinsiyeti { get; set; }
        public string  MedeniHali { get; set; }
        public string OzelDurum { get; set; }
        public string Il { get; set; }
    }
}
