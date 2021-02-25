using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IShiftInfoDal
    {
        List<ShiftInfo> GetAll(Expression<Func<ShiftInfo, bool>> filter = null);
    }
}
