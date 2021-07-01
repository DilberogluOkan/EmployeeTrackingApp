using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class CheckDto:IDto
    {
        public string CheckGnMd { get; set; }
        public string CheckIsYeri { get; set; }
        public string CheckMeslekKol { get; set; }
        public string CheckUcretTur { get; set; }
        public string CheckMsbKatilisTarih { get; set; }
        public string CheckIdarecilikDurum { get; set; }
        public string CheckGunlukCalismaSure { get; set; }
        public string CheckDogumTarihi { get; set; }
        public string CheckEngelDurum { get; set; }
        public string CheckMedeniHal { get; set; }
        public string CheckCinsiyet { get; set; }
        public string CheckIstihtamDurum { get; set; }
        public string ExcelAktarımDurum { get; set; }

    }
}
