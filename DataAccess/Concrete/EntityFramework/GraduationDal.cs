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
    public class GraduationDal : EfEntityRepositoryBase<Graduation, EmployeeContext>, IGraduationDal
    {
        public List<GraduationDto> GetGraduationDetails(Expression<Func<Graduation, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                var result = from g in filter == null ? context.Graduations : context.Graduations.Where(filter)
                             join s in context.GraduationStatus on g.EgitimDurumId equals s.EgitimDurumId
                             select new GraduationDto
                             {
                                 PersonelEgitimId = g.PersonelEgitimId,
                                 PersonelKimlikId = g.PersonelKimlikId,
                                 Bolum = g.Bolum,
                                 EgitimDurumu = s.EgitimDurumu,
                                 FakulteLiseTur = g.FakulteLiseTur,
                                 OkulAd = g.OkulAd,
                                 OkulTuru = g.OkulTuru,
                                 TahsilDerece = g.TahsilDerece
                             };
                return result.ToList();
            }
        }
    }
}
