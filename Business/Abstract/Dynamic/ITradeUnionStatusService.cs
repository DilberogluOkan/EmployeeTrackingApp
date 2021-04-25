using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Dynamic
{
    public interface ITradeUnionStatusService:IServiceRepository<TradeUnionStatus>
    {
        IDataResult<TradeUnionStatus> GetById(int tradeUnionStatusId);
        IDataResult<List<TradeUnionStatus>> GetAll();
    }
}
