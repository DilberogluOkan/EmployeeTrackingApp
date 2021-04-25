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
    public class TradeUnionStatusManager : ITradeUnionStatusService
    {
        ITradeUnionStatusDal _tradeUnionStatusDal;

        public TradeUnionStatusManager(ITradeUnionStatusDal tradeUnionStatusDal)
        {
            _tradeUnionStatusDal = tradeUnionStatusDal;
        }

        public IResult Add(TradeUnionStatus entity)
        {
            _tradeUnionStatusDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(TradeUnionStatus entity)
        {
            _tradeUnionStatusDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<TradeUnionStatus>> GetAll()
        {
            return new SuccessDataResult<List<TradeUnionStatus>>(_tradeUnionStatusDal.GetAll());
        }

        public IDataResult<TradeUnionStatus> GetById(int tradeUnionStatusId)
        {
            return new SuccessDataResult<TradeUnionStatus>(_tradeUnionStatusDal.Get(p => p.SendikaDurumId == tradeUnionStatusId));
        }

        public IResult Update(TradeUnionStatus entity)
        {
            _tradeUnionStatusDal.Update(entity);
            return new SuccessResult();
        }
    }
}
