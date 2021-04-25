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
    public class CriminalManager : ICriminalService
    {
        ICriminalDal _criminalDal;

        public CriminalManager(ICriminalDal criminalDal)
        {
            _criminalDal = criminalDal;
        }

        public IResult Add(Criminal criminal)
        {
            _criminalDal.Add(criminal);
            return new SuccessResult();
        }

        public IResult Delete(Criminal criminal)
        {
            throw new NotImplementedException();
        }

     
        public IDataResult<List<Criminal>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Criminal>> GetAllByIdentityId(int id)
        {
            return new SuccessDataResult<List<Criminal>>(_criminalDal.GetAll(p => p.PersonelKimlikId == id));
        }

        public IDataResult<Criminal> GetById(int criminalId)
        {
            return new SuccessDataResult<Criminal>(_criminalDal.Get(p => p.PersonelCezaId ==criminalId));
        }

        public IDataResult<List<CriminalDto>> GetCriminalDetails(int id)
        {
            return new SuccessDataResult<List<CriminalDto>>(_criminalDal.GetCriminalDetails(p => p.PersonelKimlikId == id));
        }

        public IResult Update(Criminal criminal)
        {
            _criminalDal.Update(criminal);
            return new SuccessResult();
        }
    }
}
