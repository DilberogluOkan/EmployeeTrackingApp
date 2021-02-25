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
    public class AdminStatusDal : IAdminStatusDal
    {
        public List<AdminStatus> GetAll(Expression<Func<AdminStatus, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                return filter == null ? context.Set<AdminStatus>().ToList()
                                      : context.Set<AdminStatus>().Where(filter).ToList();
            }
        }
    }
}
