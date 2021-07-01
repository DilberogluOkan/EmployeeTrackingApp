using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class DesignationDal : EfEntityRepositoryBase<Designation, EmployeeContext>, IDesignationDal
    {
        public List<DesignationDto> GetDesignationDtos(Expression<Func<Designation, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from c in filter == null ? context.Designations : context.Designations.Where(filter)
                             join w in context.Workplaces on c.IsYeriId equals w.IsYeriId
                             join wh in context.WorkplaceHeadquarters on w.GenelMudurlukId equals wh.GenelMudurlukId
                             join d in context.DesignationStatus on c.NakilDurumId equals d.NakilDurumId
                             join ı in context.DesignationApprovals on c.IlgiliGenelMudurOnay equals ı.OnayId
                             join p in context.DesignationApprovals on c.PersonelGenelMudurOnay equals p.OnayId
                             join ıv in context.DesignationApprovals on c.IsVerenVekiliOnay equals ıv.OnayId
                             join b in context.ReasonForDesignation on c.AtamaIstegiNedenId equals b.AtamaIstegiNedenId
                     select new DesignationDto
                             {
                                 PersonelKimlikId = c.PersonelKimlikId,
                                 PersonelAtamaId = c.PersonelAtamaId,
                                 AtamaIstegiNedenId=c.AtamaIstegiNedenId,
                                 IsYeriId=c.IsYeriId,
                                 GenelMudurluk=wh.GenelMudurluk,
                                 GenelMudurlukId=w.GenelMudurlukId,
                                 AtamaIstegiNedeni = b.AtamaIstegiNedeni,
                                 IsYeriAdi = w.IsYeriAdi,
                                 AyrilisTarihi=c.AyrilisTarihi,
                                 KatilisTarihi=c.KatilisTarihi,
                                 Aciklama=c.Aciklama,
                                 NakilDurum=d.NakilDurumu,
                                 IlgiliGenelMudurOnay=ı.OnayDurumu,
                                 IsVerenVekiliOnay = ıv.OnayDurumu,
                                 PersonelGenelMudurOnay = p.OnayDurumu,
                                  NakilTalepTarihi=c.NakilTalepTarihi



                     };

                return result.OrderByDescending(p=>p.PersonelAtamaId).ToList();
            }

       
            
        }
    }
}
