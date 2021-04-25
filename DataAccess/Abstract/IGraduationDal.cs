using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IGraduationDal:IEntityRepository<Graduation>
    {
        List<GraduationDto> GetGraduationDetails(Expression<Func<Graduation, bool>> filter = null);
    }
}
