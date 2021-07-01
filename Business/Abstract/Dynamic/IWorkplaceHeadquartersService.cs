using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Dynamic
{
    public interface IWorkplaceHeadquartersService:IServiceRepository<WorkplaceHeadquarters>
    {
        IDataResult<WorkplaceHeadquarters> GetById(int workplaceHeadquartersId);
        IDataResult<List<WorkplaceHeadquarters>> GetAll();
    }
}
