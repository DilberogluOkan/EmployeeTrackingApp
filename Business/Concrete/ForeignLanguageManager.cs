using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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
            throw new NotImplementedException();
        }

        public IResult Delete(ForeignLanguage foreignLanguage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ForeignLanguage> Get(int foreignLanguageId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ForeignLanguage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(ForeignLanguage foreignLanguage)
        {
            throw new NotImplementedException();
        }
    }
}
