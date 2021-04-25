using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class PersonIndividualDto:IDto
    {
        public int PersonelKimlikId { get; set; }
        public string MedeniHali{ get; set; }
        public string Cinsiyeti { get; set; }
        public string KanGrubu { get; set; }
        public string OzelDurumu { get; set; }
        public string EngelDurumu { get; set; }
        public string IstihtamDurumu { get; set; }
        public string ServisBilgisi { get; set; }
        public string VardiyaBilgisi { get; set; }
        public string MevcutStatusu { get; set; }
        public string Sgk { get; set; }
        public string IdarecilikDurumu { get; set; }
    }
}
