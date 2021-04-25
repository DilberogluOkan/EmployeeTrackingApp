using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IDesignationDal: IEntityRepository<Designation>
    {
        List<DesignationDto>GetDesignationDtos(Expression<Func<Designation, bool>> filter = null);
    }
}
