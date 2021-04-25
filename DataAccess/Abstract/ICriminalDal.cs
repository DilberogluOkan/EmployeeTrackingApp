using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICriminalDal:IEntityRepository<Criminal>
    {
        List<CriminalDto> GetCriminalDetails(Expression<Func<Criminal, bool>> filter = null);
    }
}
