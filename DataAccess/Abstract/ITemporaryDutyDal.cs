using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ITemporaryDutyDal:IEntityRepository<TemporaryDuty>
    {
        List<TemporaryDutyDto> GetTemporaryDutyDetails(Expression<Func<TemporaryDuty, bool>> filter = null);
    }
}
