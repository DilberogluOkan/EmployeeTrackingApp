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
    public interface IDisabilityStatusService
    {
        IResult Add(DisabilityStatus disabilityStatus);
        IResult Delete(DisabilityStatus disabilityStatus);
        IResult Update(DisabilityStatus disabilityStatus);
        IDataResult<DisabilityStatus> GetById(int disabilityStatusId);
        IDataResult<List<DisabilityStatus>> GetDisabilityCount();
        IDataResult<List<DisabilityStatus>> GetAll();
    }
}
