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
    public class ServiceInfoDal : IServiceInfoDal
    {
        public List<ServiceInfo> GetAll(Expression<Func<ServiceInfo, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                return filter == null ? context.Set<ServiceInfo>().ToList()
                                      : context.Set<ServiceInfo>().Where(filter).ToList();
            }
        }
    }
}
