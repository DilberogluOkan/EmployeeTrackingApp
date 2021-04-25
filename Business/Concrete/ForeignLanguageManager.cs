using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignLanguageManager : IForeignLanguageService
    {
        IForeignLanguageDal _foreignLanguageDal;

        public ForeignLanguageManager(IForeignLanguageDal foreignLanguageDal)
        {
            _foreignLanguageDal = foreignLanguageDal;
        }

        public IResult Add(ForeignLanguage foreignLanguage)
        {
            _foreignLanguageDal.Add(foreignLanguage);
            return new SuccessResult();
        }

        public IResult Delete(ForeignLanguage foreignLanguage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ForeignLanguage> GetById(int foreignLanguageId)
        {
            return new SuccessDataResult<ForeignLanguage>(_foreignLanguageDal.Get(p => p.YabanciDilBilgiId == foreignLanguageId));
        }

        public IDataResult<List<ForeignLanguage>> GetAll()
        {
            return new SuccessDataResult<List<ForeignLanguage>>(_foreignLanguageDal.GetAll());
        }

        public IResult Update(ForeignLanguage foreignLanguage)
        {
            _foreignLanguageDal.Update(foreignLanguage);
            return new SuccessResult();
        }

        public IDataResult<List<ForeignLanguage>> GetAllByIdentityId(int id)
        {
            return new SuccessDataResult<List<ForeignLanguage>>(_foreignLanguageDal.GetAll(p => p.PersonelKimlikId == id));
        }

        public IDataResult<List<ForeignLanguageDto>> GetForeignLanguageDetails(int id)
        {
            return new SuccessDataResult<List<ForeignLanguageDto>>(_foreignLanguageDal.GetForeignLanguageDtos(p => p.PersonelKimlikId == id));
        }
    }
}
