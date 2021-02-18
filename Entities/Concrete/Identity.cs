using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{    //Kimlik Bilgisi
    public class Identity:IEntity
    {
        [Key]
        public int PersonelKimlikId { get; set; }
        public int PersonelNufusId { get; set; }
        public int CinsiyetId { get; set; }
        public int OzelDurumId { get; set; }
        public int MedeniHalId { get; set; }
        public int IlId { get; set; }
        public int KanGrupId { get; set; }

        [StringLength(11)]
        public string TcKimlikNo { get; set; }
        [StringLength(20)]
        public string Adi { get; set; }

        [StringLength(25)]
        public string Soyadi { get; set; }

        public string CalistigiKurum { get; set; }

        [StringLength(12)]
        public string SicilNo { get; set; }

        [StringLength(20)]
        public string AnaAdi { get; set; }
        [StringLength(20)]
        public string BabaAdi { get; set; }


        [DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; }

        [StringLength(14)]
        public string DogumYeriIl { get; set; }

        [StringLength(14)]
        public string DogumYeriIlce { get; set; }

        [StringLength(14)]
        public string DogumYeri { get; set; }

        [StringLength(15)]
        public string Sinif { get; set; }

        [StringLength(10)]
        public string Unvan { get; set; }
        [StringLength(15)]
        public string Brans { get; set; }
        [StringLength(50)]
        public string BaglıOlduguKuvvet { get; set; }

        [DataType(DataType.Date)]
        public DateTime MsbKatilisTarihi { get; set; }

        [StringLength(25)]
        public string KizlikSoyadi { get; set; }

        [StringLength(12)]
        public string SosyalGüvenlikNo { get; set; }

        public DateTime Duhul { get; set; }

        public string OyakNo { get; set; }

        public string VergiNo { get; set; }

        public string VergiDairesi { get; set; }

        public bool EhliyetDurumu { get; set; }

        public string EhliyetSinifi { get; set; }

        public string BelgeNo { get; set; }

        public string YoneticiDurumu { get; set; }

        public string GorevAlani { get; set; }

        public string Memleketi { get; set; }

        public DateTime GarnizonKatilisTarihi { get; set; }

        public int KistasAylikOran { get; set; }

        public string Alan1 { get; set; }

        public string Alan2 { get; set; }

        public string Alan3 { get; set; }

        public string Aciklama { get; set; }

        public string GirisYapan { get; set; }

        public DateTime GirisTarihi { get; set; }

        public string GuncellemeYapan { get; set; }

        public DateTime GuncellemeTarihi { get; set; }

        public string GuncellemeAciklama { get; set; }

        public string VekalatEdilen { get; set; }

        public string IstihdamDurumu { get; set; }

        public string UcretTip { get; set; }

        public string IsSiralamaTuru { get; set; }

        public string IsSiraNo { get; set; }

        public string IsMeslekKolu { get; set; }

        public DateTime IlisikKesmeTarih { get; set; }

        public bool GiyimMustahakmi { get; set; }

        public string OyakAidat { get; set; }

        public double OyakEkAidat { get; set; }

        public string Alan4 { get; set; }

        public double YipranmaTazminati { get; set; }

        public DateTime YiprTazmiBaşlamaTarih { get; set; }

        public DateTime YiprTazmiBitisTarih { get; set; }

        public string TabiOlduguKanun { get; set; }

        public bool PatlayiciylaUgrasiyorMu { get; set; }

        public string SigortaSicilNumarası { get; set; }

        public bool AktarımDurumu { get; set; }

        public string Fotograf { get; set; }



        //-----------------------< İLİŞKİLER >---------------------

        public virtual BirthCertificate BirthCertificates { get; set; }

        public virtual ICollection<Graduation> Graduations { get; set; }
        public virtual ICollection<Designation> Designations { get; set; }
        public virtual ICollection<Criminal> Criminals { get; set; }
        public virtual ICollection<TemporaryDuty> TemporaryDuties { get; set; }
        public virtual ICollection<Adaptation> Adaptations { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Award> Awards { get; set; }
        public virtual ICollection<Promotion> Promotions { get; set; }

        public virtual Military Militaries { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual BloodGroup BloodGroups { get; set; }

        public virtual MaritalStatus MaritalStatuses { get; set; }
        public virtual DisabilityStatus DisabilityStatuses { get; set; }
        public virtual Province Provinces { get; set; }

    }
}
