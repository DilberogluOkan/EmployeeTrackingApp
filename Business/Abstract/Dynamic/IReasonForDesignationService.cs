using Core.Utilities.Results;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Dynamic
{
    public interface IReasonForDesignationService
    {
        IResult Add(ReasonForDesignation reasonForDesignation);
        IResult Delete(ReasonForDesignation reasonForDesignation);
        IResult Update(ReasonForDesignation reasonForDesignation);
        IDataResult<ReasonForDesignation> GetById(int reasonForDesignationId);
        IDataResult<List<ReasonForDesignation>> GetAll();

    }
}
