using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{    //Nufus Bilgisi
    public class BirthCertificate:IEntity
    {
        [Key]
        public int PersonelNufusId { get; set; }

        public string SeriNo { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string MahalleKoy { get; set; }
        public string CiltNo { get; set; }
        public string SiraNo { get; set; }
        public string AileSiraNo { get; set; }
        public string NufusAciklama1 { get; set; }
        public string NufusAciklama2 { get; set; }
        public string GirisYapan { get; set; }
        public DateTime GirisTarih { get; set; }
        public string VekaletEdilen { get; set; }
        public string VerildigiIl { get; set; }
        public DateTime VerildigiTarih { get; set; }
        public string VerildigiIlce { get; set; }
        public string KayitNo { get; set; }
        public string VerilisNedeni { get; set; }
        public string AktarimDurumu { get; set; }
        public string Turu { get; set; }
        public string KimlikSeriNo { get; set; }
        public string KimlikUyrugu { get; set; }
        public DateTime KimlikSonGecerlikTarih { get; set; }
        //  public  PersonelKimlik PersonelKimlik { get; set; }

    }
}
