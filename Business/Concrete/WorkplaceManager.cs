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
    public class WorkplaceManager : IWorkplaceService
    {
        IWorkplaceDal _workplaceDal;

        public WorkplaceManager(IWorkplaceDal workplaceDal)
        {
            _workplaceDal = workplaceDal;
        }

        public IResult Add(Workplace workplace)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Workplace workplace)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Workplace>> GetAll()
        {
            return new SuccessDataResult<List<Workplace>>(_workplaceDal.GetAll());
        }

        public IDataResult<List<Workplace>> GetAllByIdentityId(int id)
        {
           return new SuccessDataResult<List<Workplace>>(_workplaceDal.GetAll(p => p.PersonelIsyeriId== id));

        }

        public IDataResult<Workplace> GetById(int workplaceId)
        {
            return new SuccessDataResult<Workplace>(_workplaceDal.Get(p => p.PersonelIsyeriId == workplaceId));
        }

        public IResult Update(Workplace workplace)
        {
            _workplaceDal.Update(workplace);
            return new SuccessResult();
        }
    }
}
