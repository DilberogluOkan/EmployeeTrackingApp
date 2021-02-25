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
    public class WorkingStatusDal : IWorkingStatusDal
    {
        public List<WorkingStatus> GetAll(Expression<Func<WorkingStatus, bool>> filter = null)
        {
           
                using (EmployeeContext context = new EmployeeContext())
                {
                    return filter == null ? context.Set<WorkingStatus>().ToList()
                                          : context.Set<WorkingStatus>().Where(filter).ToList();
                }

           
        }
    }
}
