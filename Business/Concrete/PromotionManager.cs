using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PromotionManager : IPromotionService
    {
        IPromotionDal _promotionDal;

        public PromotionManager(IPromotionDal promotionDal)
        {
            _promotionDal = promotionDal;
        }

        public IResult Add(Promotion promotion)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Promotion promotion)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Promotion> Get(int promotionId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Promotion>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Promotion promotion)
        {
            throw new NotImplementedException();
        }
    }
}
