using Core.Utilities.Results;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Dynamic
{
    public interface IReasonForPromotionService
    {
        IResult Add(ReasonForPromotion reasonForPromotion);
        IResult Delete(ReasonForPromotion reasonForPromotion);
        IResult Update(ReasonForPromotion reasonForPromotion);
        IDataResult<ReasonForPromotion> GetById(int reasonForPromotionId);
        IDataResult<List<ReasonForPromotion>> GetAll();

    }
}
