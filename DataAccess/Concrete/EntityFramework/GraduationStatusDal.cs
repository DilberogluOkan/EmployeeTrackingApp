using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class GraduationStatusDal : IGraduationStatusDal
    {
        public List<GraduationStatus> GetAll(Expression<Func<GraduationStatus, bool>> filter = null)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                return filter == null ? context.Set<GraduationStatus>().ToList()
                                      : context.Set<GraduationStatus>().Where(filter).ToList();
            }
        }
    }
}
