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
    public interface ITradeUnionNameService:IServiceRepository<TradeUnionName>
    {
        IDataResult<TradeUnionName> GetById(int tradeUnionNameId);
        IDataResult<List<TradeUnionName>> GetAll();
    }
}
