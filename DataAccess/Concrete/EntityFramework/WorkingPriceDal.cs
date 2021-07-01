using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class WorkingPriceDal : EfEntityRepositoryBase<WorkingPrice, EmployeeContext>, IWorkingPriceDal
    {
        public List<PriceDto> GetPriceDetails(Expression<Func<WorkingPrice, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from c in filter ==null ?context.WorkingPrices:context.WorkingPrices.Where(filter)
                             join v in context.DailyWorkingTimes on c.GunlukCalismaSureId equals v.GunlukCalismaSureId
                             join n in context.PriceGradeRises on c.UcretDerecesineTerfiId equals n.UcretDerecesineTerfiId
                             join h in context.PriceTypes on c.UcretTurId equals h.UcretTurId

                             select new PriceDto
                             {
                                 PersonelKimlikId = c.PersonelKimlikId,
                                   CalismaUcretBilgiId = c.CalismaUcretBilgiId,
                                    UcretTuru=h.UcretTuru,
                                     UcretDerecesi = c.UcretDerece,
                                      GunlukCalismaSuresi = v.GunlukCalismaSuresi,
                                       UcretDerecesineTerfiNedeni = n.UcretDerecesineTerfiNedeni,
                                       SonUcretDerecesineYukselmeTarih=c.SonUcretDerecesineYukselmeTarih
                             };

                return result.ToList();

            }
        }
    }
}
