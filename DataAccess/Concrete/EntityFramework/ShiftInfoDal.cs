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
    public class ShiftInfoDal : IShiftInfoDal
    {
        public List<ShiftInfo> GetAll(Expression<Func<ShiftInfo, bool>> filter = null)
        {
            using (EmployeeContext context =new EmployeeContext())
            {
                return filter == null ? context.Set<ShiftInfo>().ToList()
                                      : context.Set<ShiftInfo>().Where(filter).ToList();
            }

        }
    }
}
