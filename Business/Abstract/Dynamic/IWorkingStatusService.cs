using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Dynamic
{
    public interface IWorkingStatusService
    {
        IDataResult<List<WorkingStatus>> GetAll();
        IResult Add(WorkingStatus workingStatus);
        IResult Delete(WorkingStatus workingStatus);
        IResult Update(WorkingStatus workingStatus);
        IDataResult<WorkingStatus> GetById(int workingStatusId);
       
    }
}
