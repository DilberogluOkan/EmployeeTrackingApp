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
    public class PromotionDal : EfEntityRepositoryBase<Promotion, EmployeeContext>, IPromotionDal
    {
        public List<PromotionDto> GetPromotionDetails(Expression<Func<Promotion, bool>> filter = null)
        {
            using (EmployeeContext context=new EmployeeContext())
            {
                var result = from p in filter == null ? context.Promotions : context.Promotions.Where(filter)
                             join r in context.ReasonForPromotions on p.TerfiNedenId equals r.TerfiNedenId
                             select new PromotionDto
                             {
                                 PersonelKimlikId = p.PersonelKimlikId,
                                 PersonelTerfiId = p.PersonelTerfiId,
                                 Derece = p.Derece,
                                 TerfiTarihi = p.TerfiTarihi,
                                 Aciklama = p.Aciklama,
                                 TerfiNedeni = r.TerfiNedeni
                             };
                return result.ToList();
            }
        }
    }
}
