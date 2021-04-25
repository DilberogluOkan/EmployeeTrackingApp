using Core.Utilities.Results;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Dynamic
{
    public interface IReasonForTemporaryDutyService
    {
        IResult Add(ReasonForTemporaryDuty reasonForTemporaryDuty);
        IResult Delete(ReasonForTemporaryDuty reasonForTemporaryDuty);
        IResult Update(ReasonForTemporaryDuty reasonForTemporaryDuty);
        IDataResult<ReasonForTemporaryDuty> GetById(int reasonForTemporaryDutyId);
        IDataResult<List<ReasonForTemporaryDuty>> GetAll();
    }
}
