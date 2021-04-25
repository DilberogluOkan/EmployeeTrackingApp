using Core.Entities;
using Entities.Concrete.DynamicDataEntity;
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
        public int? PersonelNufusId { get; set; }
        public int PersonelAskerlikId { get; set; }
        public int MedeniHalId { get; set; }
        public int CinsiyetId { get; set; }
        public int KanGrupId { get; set; }
        public int EngelDurumId { get; set; }
        public int IstihtamDurumId { get; set; }
        public int ServisBilgiId { get; set; }
        public int VardiyaBilgiId { get; set; }
        public string TisMeslekKolId { get; set; }
        //public int SendikaBilgiId { get; set; }
        public int MevcutStatuId { get; set; }

        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SosyalGüvenlikNo { get; set; }
        //public string SicilNo { get; set; }
        public string KizlikSoyadi { get; set; }
        
        
       
        public DateTime? DogumTarihi { get; set; }
        //public int DogumYeri { get; set; }//Doğum yeri
        public string AnaAdi { get; set; }
        public string BabaAdi { get; set; }
       
        public DateTime? MsbKatilisTarih { get; set; }
        public int IsYeriId { get; set; }
        public int IdarecilikDurumId { get; set; }
        public string CocukSayisi { get; set; }



        //public string DogumYeriIl { get; set; }
        //public string DogumYeriIlce { get; set; }
        //public string Sinif { get; set; }
        //public string Unvan { get; set; }
        // public string BaglıOlduguKuvvet { get; set; }
        //public int IlId { get; set; }




        //-----------------------< İLİŞKİLER >---------------------

        //public virtual BirthCertificate BirthCertificates { get; set; }

        //public virtual Military Militaries { get; set; }

        //public virtual Gender Gender { get; set; }

        //public virtual BloodGroup BloodGroup { get; set; }

        //public virtual MaritalStatus MaritalStatus { get; set; }

        //public virtual DisabilityStatus DisabilityStatus { get; set; }

        //public virtual Province Province { get; set; }
       
        //public virtual WorkingStatus WorkingStatus{ get; set; }
        //public virtual ServiceInfo ServiceInfo { get; set; }
        //public virtual ShiftInfo ShiftInfo { get; set; }
        //public virtual Workplace Workplace { get; set; }
        //public virtual AdminStatus AdminStatus { get; set; }

   

        //public virtual ICollection<Graduation> Graduations { get; set; }
        //public virtual ICollection<Designation> Designations { get; set; }
        //public virtual ICollection<Criminal> Criminals { get; set; }
        //public virtual ICollection<TemporaryDuty> TemporaryDuties { get; set; }
        //public virtual ICollection<Adaptation> Adaptations { get; set; }
        //public virtual ICollection<Permission> Permissions { get; set; }
        //public virtual ICollection<Course> Courses { get; set; }
        //public virtual ICollection<Award> Awards { get; set; }
        //public virtual ICollection<Promotion> Promotions { get; set; }


    }
}
