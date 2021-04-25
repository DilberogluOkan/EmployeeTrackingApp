using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IForeignLanguageService
    {
        IResult Add(ForeignLanguage foreignLanguage);
        IResult Delete(ForeignLanguage foreignLanguage);
        IResult Update(ForeignLanguage foreignLanguage);
        IDataResult<List<ForeignLanguage>> GetAll();
      
        IDataResult<ForeignLanguage> GetById(int foreignLanguageId);
        IDataResult<List<ForeignLanguage>> GetAllByIdentityId(int id);
        IDataResult<List<ForeignLanguageDto>> GetForeignLanguageDetails(int id);
    }
}
