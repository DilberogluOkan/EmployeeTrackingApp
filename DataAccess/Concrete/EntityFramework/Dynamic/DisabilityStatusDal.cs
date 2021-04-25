using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Abstract.Dynamic;
using Entities.Concrete;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Dynamic
{
    public class DisabilityStatusDal :EfEntityRepositoryBase<DisabilityStatus,EmployeeContext>,IDisabilityStatusDal
    {
       
    }
}
