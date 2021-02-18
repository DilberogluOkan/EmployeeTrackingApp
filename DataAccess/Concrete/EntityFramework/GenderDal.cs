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
    public class GenderDal : IGenderDal
    {
        public List<Gender> GetAll(Expression<Func<Gender, bool>> filter = null)
        {
            using (EmployeeContext context=new EmployeeContext())
            {
                return filter == null ? context.Set<Gender>().ToList()
                                      : context.Set<Gender>().Where(filter).ToList();
            }
        }
    }
}
