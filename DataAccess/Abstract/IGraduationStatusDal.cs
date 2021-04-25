using Entities.Concrete;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGraduationStatusDal
    {
        List<GraduationStatus> GetAll(Expression<Func<GraduationStatus, bool>> filter = null);
    }
}
