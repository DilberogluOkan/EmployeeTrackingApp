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
    public class PriceGradeDal : IPriceGradeDal
    {
        public List<PriceGrade> GetAll(Expression<Func<PriceGrade, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                return filter == null ? context.Set<PriceGrade>().ToList()
                                      : context.Set<PriceGrade>().Where(filter).ToList();
            }
        }
    }
}
