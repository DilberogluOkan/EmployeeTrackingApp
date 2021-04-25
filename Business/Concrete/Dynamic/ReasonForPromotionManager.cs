using Business.Abstract.Dynamic;
using Core.Utilities.Results;
using DataAccess.Abstract.Dynamic;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Dynamic
{
    public class ReasonForPromotionManager : IReasonForPromotionService
    {
        IReasonForPromotionDal _reasonForPromotionDal;

        public ReasonForPromotionManager(IReasonForPromotionDal reasonForPromotionDal)
        {
            _reasonForPromotionDal = reasonForPromotionDal;
        }

        public IResult Add(ReasonForPromotion reasonForPromotion)
        {
            _reasonForPromotionDal.Add(reasonForPromotion);
            return new SuccessResult();

        }

        public IResult Delete(ReasonForPromotion reasonForPromotion)
        {
            _reasonForPromotionDal.Delete(reasonForPromotion);
            return new SuccessResult();
        }

        public IDataResult<List<ReasonForPromotion>> GetAll()
        {
            return new SuccessDataResult<List<ReasonForPromotion>>(_reasonForPromotionDal.GetAll());
        }

        public IDataResult<ReasonForPromotion> GetById(int reasonForPromotionId)
        {
            return new SuccessDataResult<ReasonForPromotion>(_reasonForPromotionDal.Get(p => p.TerfiNedenId == reasonForPromotionId));
        }

        public IResult Update(ReasonForPromotion reasonForPromotion)
        {
            _reasonForPromotionDal.Update(reasonForPromotion);
            return new SuccessResult();
        }
    }
}
