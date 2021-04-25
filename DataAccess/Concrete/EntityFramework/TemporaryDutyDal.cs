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
    public class TemporaryDutyDal : EfEntityRepositoryBase<TemporaryDuty, EmployeeContext>, ITemporaryDutyDal
    {
        public List<TemporaryDutyDto> GetTemporaryDutyDetails(Expression<Func<TemporaryDuty, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())

            {
                var result = from t in filter == null ? context.TemporaryDuties : context.TemporaryDuties.Where(filter)
                             join w in context.Workplaces on t.IsYeriId equals w.IsYeriId
                             join r in context.ReasonForTemporaryDuties on t.GeciciGorevNedenId equals r.GeciciGorevNedenId
                             select new TemporaryDutyDto
                             {
                                 PersonelKimlikId = t.PersonelKimlikId,
                                 PersonelGeciciGorevId = t.PersonelGeciciGorevId,
                                 IsYeriAdi = w.IsYeriAdi,
                                 GeciciGorevNedeni = r.GeciciGorevNedeni,
                                 GorevYeri = t.GorevYeri,
                                 BaslamaTarihi = t.BaslamaTarihi,
                                 BitisTarihi = t.BitisTarihi

                             };
                return result.ToList();
            }
        }
    }
}
