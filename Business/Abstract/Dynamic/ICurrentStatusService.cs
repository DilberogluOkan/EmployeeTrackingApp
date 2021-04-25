using Core.Utilities.Results;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Dynamic
{
   public  interface ICurrentStatusService
    {
        IResult Add(CurrentStatus currentStatus);
        IResult Delete(CurrentStatus currentStatus);
        IResult Update(CurrentStatus currentStatus);
        IDataResult<CurrentStatus> GetById(int  currentStatusId);
        IDataResult<List<CurrentStatus>> GetAll();
    }
}
