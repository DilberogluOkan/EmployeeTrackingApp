using Core.Utilities.Results;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Dynamic
{
    public interface IReasonForCriminalService
    {
        IResult Add(ReasonForCriminal reasonForCriminal);
        IResult Delete(ReasonForCriminal reasonForCriminal);
        IResult Update(ReasonForCriminal reasonForCriminal);
        IDataResult<ReasonForCriminal> GetById(int reasonForCriminalId);
        IDataResult<List<ReasonForCriminal>> GetAll();
    }
}
