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
    public class PriceTypeDal : IPriceTypeDal
    {
        public List<PriceType> GetAll(Expression<Func<PriceType, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                return filter == null ? context.Set<PriceType>().ToList()
                                      : context.Set<PriceType>().Where(filter).ToList();
            }
        }
    }
}
