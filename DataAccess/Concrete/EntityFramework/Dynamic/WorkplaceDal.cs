using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Dynamic
{
    public class WorkplaceDal:EfEntityRepositoryBase<Workplace,EmployeeContext>,IWorkplaceDal
    {

    }
}
