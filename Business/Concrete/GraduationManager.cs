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
    public class GraduationManager : IGraduationService
    {
        IGraduationDal _graduationDal;

        public GraduationManager(IGraduationDal graduationDal)
        {
            _graduationDal = graduationDal;
        }

        public IResult Add(Graduation graduation)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Graduation graduation)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Graduation> Get(int graduationId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Graduation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Graduation graduation)
        {
            throw new NotImplementedException();
        }
    }
}
