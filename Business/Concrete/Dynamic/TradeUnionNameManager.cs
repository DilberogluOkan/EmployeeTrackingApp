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
    public class TradeUnionNameManager : ITradeUnionNameService
    {
        ITradeUnionNameDal _tradeUnionNameDal;

        public TradeUnionNameManager(ITradeUnionNameDal tradeUnionNameDal)
        {
            _tradeUnionNameDal = tradeUnionNameDal;
        }

        public IResult Add(TradeUnionName entity)
        {
            _tradeUnionNameDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(TradeUnionName entity)
        {
            _tradeUnionNameDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<TradeUnionName>> GetAll()
        {
            return new SuccessDataResult<List<TradeUnionName>>(_tradeUnionNameDal.GetAll());
        }

        public IDataResult<TradeUnionName> GetById(int tradeUnionNameId)
        {
            return new SuccessDataResult<TradeUnionName>(_tradeUnionNameDal.Get(p => p.SendikaAdId == tradeUnionNameId));
        }

        public IResult Update(TradeUnionName entity)
        {
            _tradeUnionNameDal.Update(entity);
            return new SuccessResult();
        }
    }
}
