using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class MilitaryStatusDal:EfEntityRepositoryBase<MilitaryStatus,EmployeeContext>,IMilitaryStatusDal
    {
    }
}
