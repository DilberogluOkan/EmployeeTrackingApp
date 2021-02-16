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
    public class CriminalManager : ICriminalService
    {
        ICriminalDal _criminalDal;

        public CriminalManager(ICriminalDal criminalDal)
        {
            _criminalDal = criminalDal;
        }

        public IResult Add(Criminal criminal)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Criminal criminal)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Criminal> Get(int criminalId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Criminal>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Criminal criminal)
        {
            throw new NotImplementedException();
        }
    }
}
