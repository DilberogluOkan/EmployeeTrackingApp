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
    public class ForeignLanguageDal : EfEntityRepositoryBase<ForeignLanguage, EmployeeContext>, IForeignLanguageDal
    {
        public List<ForeignLanguageDto> GetForeignLanguageDtos(Expression<Func<ForeignLanguage, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from c in filter == null ? context.ForeignLanguages : context.ForeignLanguages.Where(filter)
                             join d in context.LanguageNames on c.YabanciDilId equals d.YabanciDilId
                             select new ForeignLanguageDto
                             {
                                 PersonelKimlikId = c.PersonelKimlikId,
                                 BelgeTarihi = c.BelgeTarihi,
                                 Puani = c.Puani,
                                 SinavAdi = c.SinavAdi,
                                 YabanciDilAdi = d.YabanciDil,
                                 YabanciDilBilgiId = c.YabanciDilBilgiId,
                                 YabanciDilId=c.YabanciDilId
                             };

                return result.ToList();
            }

        }
    }
}
