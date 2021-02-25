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
    public class DailyWorkingTimeDal : IDailyWorkingTimeDal
    {
        public List<DailyWorkingTime> GetAll(Expression<Func<DailyWorkingTime, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                return filter == null ? context.Set<DailyWorkingTime>().ToList()
                                      : context.Set<DailyWorkingTime>().Where(filter).ToList();
            }
        }
    }
}
