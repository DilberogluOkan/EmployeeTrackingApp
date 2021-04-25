using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LanguageNameManager : ILanguageNameService
    {
        ILanguageNameDal _languageNameDal;

        public LanguageNameManager(ILanguageNameDal languageNameDal)
        {
            _languageNameDal = languageNameDal;
        }

        public IResult Add(LanguageName entity)
        {
            _languageNameDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(LanguageName entity)
        {
            _languageNameDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<LanguageName>> GetAll()
        {
            return new SuccessDataResult<List<LanguageName>>(_languageNameDal.GetAll());
        }

        public IDataResult<LanguageName> GetById(int languageNameId)
        {
            return new SuccessDataResult<LanguageName>(_languageNameDal.Get(p=>p.YabanciDilId== languageNameId));
        }

        public IResult Update(LanguageName entity)
        {
            _languageNameDal.Update(entity);
            return new SuccessResult();
        }
    }
}
