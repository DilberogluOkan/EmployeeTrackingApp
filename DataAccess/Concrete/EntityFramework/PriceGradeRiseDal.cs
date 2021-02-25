using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class PriceGradeRiseDal : IPriceGradeRiseDal
    {
        public List<PriceGradeRise> GetAll(Expression<Func<PriceGradeRise, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                return filter == null ? context.Set<PriceGradeRise>().ToList()
                                      : context.Set<PriceGradeRise>().Where(filter).ToList();
            }
        }
    }
}
