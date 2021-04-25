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
    public class TemporaryDutyManager : ITemporaryDutyService
    {
        ITemporaryDutyDal _temporaryDutyDal;

        public TemporaryDutyManager(ITemporaryDutyDal temporaryDutyDal)
        {
            _temporaryDutyDal = temporaryDutyDal;
        }

        public IResult Add(TemporaryDuty temporaryDuty)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(TemporaryDuty temporaryDuty)
        {
            throw new NotImplementedException();
        }

        public IDataResult<TemporaryDuty> GetById(int temporaryDutyId)
        {
            return new SuccessDataResult<TemporaryDuty>(_temporaryDutyDal.Get(p => p.PersonelGeciciGorevId == temporaryDutyId));
        }

        public IDataResult<List<TemporaryDuty>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(TemporaryDuty temporaryDuty)
        {
            _temporaryDutyDal.Update(temporaryDuty);
            return new SuccessResult();
        }

        public IDataResult<List<TemporaryDuty>> GetAllByIdentityId(int id)
        {
            return new SuccessDataResult<List<TemporaryDuty>>(_temporaryDutyDal.GetAll(p => p.PersonelKimlikId == id));
        }

        public IDataResult<List<TemporaryDutyDto>> GetAllTemporaryDutyDetails(int id)

        {
            return new SuccessDataResult<List<TemporaryDutyDto>>(_temporaryDutyDal.GetTemporaryDutyDetails(p => p.PersonelKimlikId == id));
        }

        public IDataResult<List<TemporaryDutyDto>> GetTemporaryDutyDetails(int id)
        {
            return new SuccessDataResult<List<TemporaryDutyDto>>(_temporaryDutyDal.GetTemporaryDutyDetails(p => p.PersonelGeciciGorevId == id));


        }
    }
}
