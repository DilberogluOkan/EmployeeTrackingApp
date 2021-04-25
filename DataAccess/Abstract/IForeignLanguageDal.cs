using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IForeignLanguageDal:IEntityRepository<ForeignLanguage>
    {
        List<ForeignLanguageDto> GetForeignLanguageDtos(Expression<Func<ForeignLanguage, bool>> filter = null);
    }
}
