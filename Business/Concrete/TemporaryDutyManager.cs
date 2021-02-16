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

        public IDataResult<TemporaryDuty> Get(int temporaryDutyId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TemporaryDuty>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(TemporaryDuty temporaryDuty)
        {
            throw new NotImplementedException();
        }
    }
}
