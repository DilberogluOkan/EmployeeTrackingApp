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
    public class MilitaryManager : IMilitaryService
    {
        IMilitaryDal _militaryDal;

        public MilitaryManager(IMilitaryDal militaryDal)
        {
            _militaryDal = militaryDal;
        }

        public IResult Add(Military military)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Military military)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Military> Get(int militaryId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Military>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Military military)
        {
            throw new NotImplementedException();
        }
    }
}
