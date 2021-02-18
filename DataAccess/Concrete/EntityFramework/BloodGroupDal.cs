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
    public class BloodGroupDal : IBloodGroup
    {
        public List<BloodGroup> GetAll(Expression<Func<BloodGroup, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                return filter == null
                                    ? context.Set<BloodGroup>().ToList()
                                    : context.Set<BloodGroup>().Where(filter).ToList();
            }
        }
    }
}
