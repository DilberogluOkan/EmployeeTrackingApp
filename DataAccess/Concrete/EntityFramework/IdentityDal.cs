using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.Dto;
using System.Linq.Expressions;
using System.Data.Entity;

namespace DataAccess.Concrete.EntityFramework
{
    public class IdentityDal : EfEntityRepositoryBase<Identity, EmployeeContext>, IIdentityDal
    {
      

        public List<PersonDto> GetPersonDetails(Expression<Func<Identity, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from i in filter == null ? context.Identities : context.Identities.Where(filter)
                             join w in context.Workplaces on i.IsYeriId equals w.IsYeriId
                             select new PersonDto
                             {
                                 PersonelKimlikId = i.PersonelKimlikId,
                                 TcNo = i.TcKimlikNo,
                                 Adi = i.Adi,
                                 Soyadi = i.Soyadi,
                                 CalistigiKurum = w.IsYeriAdi,
                                 Birimi = w.Birimi
                             };
                return result.ToList();


            }
        }

        public List<PersonGeneralDto> GetPersonGeneralDetails(Expression<Func<Identity, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from i in filter == null ? context.Identities : context.Identities.Where(filter)

                             //join p in context.Provinces on i.DogumYeri equals p.IlId
                             join m in context.TisJobCodes on i.TisMeslekKolId equals m.TisMeslekKodId
                             select new PersonGeneralDto
                             {
                                 PersonelKimlikId = i.PersonelKimlikId,
                                 Adi = i.Adi,
                                 Soyadi = i.Soyadi,
                                 DogumTarihi = i.DogumTarihi,
                                 //DogumYeri = p.IlAdi,
                                 KatilisTarih = i.MsbKatilisTarih,
                                 MeslekKol = m.TisMeslekAdi,
                                
                                 TcKimlikNo = i.TcKimlikNo,

                             };
                return result.ToList();


            }
        }

        public List<PersonIndividualDto> GetPersonIndividualDtoDetails(Expression<Func<Identity, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from i in filter == null ? context.Identities : context.Identities.Where(filter)
                             join g in context.Genders on i.CinsiyetId equals g.CinsiyetId
                             join m in context.MaritalStatus on i.MedeniHalId equals m.MedeniHalId
                             join k in context.BloodGroups on i.KanGrupId equals k.KanGrupId
                             join d in context.DisabilityStatus on i.EngelDurumId equals d.EngelDurumId
                             join p in context.PrivateStatus on d.OzelDurumId equals p.OzelDurumId
                             join s in context.ServiceInfoes on i.ServisBilgiId equals s.ServisBilgiId
                             join w in context.WorkingStatus on i.IstihtamDurumId equals w.IstihtamDurumId
                             join v in context.ShiftInfoes on i.VardiyaBilgiId equals v.VardiyaBilgiId
                             join c in context.CurrentStatus on i.MevcutStatuId equals c.MevcutStatuId
                             join a in context.AdminStatus on i.IdarecilikDurumId equals a.IdarecilikDurumId
                             select new PersonIndividualDto
                             {
                                 PersonelKimlikId = i.PersonelKimlikId,
                                 MedeniHali = m.MedeniHali,
                                 KanGrubu = k.KanGrubu,
                                 EngelDurumu = d.EngelDurumu,
                                 OzelDurumu = p.OzelDurumu,
                                 Cinsiyeti = g.Cinsiyeti,
                                 ServisBilgisi = s.ServisBilgisi,
                                 IstihtamDurumu = w.IstihtamDurumu,
                                 Sgk = i.SosyalGüvenlikNo,
                                 VardiyaBilgisi = v.VardiyaBilgisi,
                                 MevcutStatusu = c.MevcutStatu,
                                 IdarecilikDurumu = a.IdarecilikDurumu
                             };
                return result.ToList();


            }
        }

        public List<PersonTradeUnionInfoDto> GetPersonTradeUnionInfoDetails(Expression<Func<Identity, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from i in filter == null ? context.Identities : context.Identities.Where(filter)
                             join t in context.TradeUnionInfoes on i.PersonelKimlikId equals t.SendikaBilgiId
                             join ts in context.TradeUnionStatus on t.SendikaDurumId equals ts.SendikaDurumId
                             join tn in context.TradeUnionNames on t.SendikaAdId equals tn.SendikaAdId
                             select new PersonTradeUnionInfoDto
                             {
                                 PersonelKimlikId = i.PersonelKimlikId,
                                 SendikaAdi = tn.SendikaAdi,
                                 SendikaBilgiId = t.SendikaBilgiId,
                                 SendikaDurumu = ts.SendikaDurumu
                             };
                return result.ToList();

                ;
            }
        }

        public List<PersonWorkplaceDto> GetPersonWorkplaceDtoDetails(Expression<Func<Identity, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from i in filter == null ? context.Identities : context.Identities.Where(filter)
                             join w in context.Workplaces on i.IsYeriId equals w.IsYeriId
                             select new PersonWorkplaceDto
                             {
                                 PersonelKimlikId = i.PersonelKimlikId,
                                 Il = w.Il,
                                 IsYeriId = w.IsYeriId,
                                 IsYeriSicilNu = w.IsYeriSicilNu,
                                 Kuvvet = w.Kuvvet,
                                 IsYeriAdi = w.IsYeriAdi,
                                 Birimi = w.Birimi
                             };
                return result.ToList();


            }
        }

       
    }
}
