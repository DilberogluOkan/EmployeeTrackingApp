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
    public class DisabilityStatusDal : IDisabilityStatusDal
    {
        public List<DisabilityStatus> GetAll(Expression<Func<DisabilityStatus, bool>> filter = null)
        {
            using (EmployeeContext context =new EmployeeContext())
            {
                return filter == null ? context.Set<DisabilityStatus>().ToList()
                                    : context.Set<DisabilityStatus>().Where(filter).ToList();
            }
        }
    }
}
