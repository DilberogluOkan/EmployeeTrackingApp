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
    public class MaritalStatusDal : IMaritalStatusDal
    {
        public List<MaritalStatus> GetAll(Expression<Func<MaritalStatus, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext()) 
            {
                return filter == null ? context.Set<MaritalStatus>().ToList()
                                    : context.Set<MaritalStatus>().Where(filter).ToList();
            }
        }
    }
}
