using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TradeUnionInfoManager : ITradeUnionInfoService
    {
        ITradeUnionInfoDal _tradeUnionInfoDal;

        public TradeUnionInfoManager(ITradeUnionInfoDal tradeUnionInfoDal)
        {
            _tradeUnionInfoDal = tradeUnionInfoDal;
        }

        public IResult Add(TradeUnionInfo entity)
        {
            _tradeUnionInfoDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(TradeUnionInfo entity)
        {
            _tradeUnionInfoDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<TradeUnionInfo>> GetAll()
        {
            return new SuccessDataResult<List<TradeUnionInfo>>(_tradeUnionInfoDal.GetAll());
        }

     

        public IDataResult<TradeUnionInfo> GetById(int tradeUnionInfoId)
        {
            return new SuccessDataResult<TradeUnionInfo>(_tradeUnionInfoDal.Get(p=>p.SendikaBilgiId==tradeUnionInfoId));
        }

        public IResult Update(TradeUnionInfo entity)
        {
            _tradeUnionInfoDal.Update(entity);
            return new SuccessResult();
        }
    }
}
