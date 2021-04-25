using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IWorkingPriceDal:IEntityRepository<WorkingPrice>
    {
        List<PriceDto> GetPriceDetails(Expression<Func<WorkingPrice,bool>> filter=null);
    }
}
