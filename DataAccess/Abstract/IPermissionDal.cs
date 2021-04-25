using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IPermissionDal:IEntityRepository<Permission>
    {
        List<PermissionDto> GetPermissionDetails(Expression<Func<Permission, bool>> filter = null);
    }
}
