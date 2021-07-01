using Business.Abstract.Dynamic;
using Core.Utilities.Results;
using DataAccess.Abstract.Dynamic;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Dynamic
{
    public class WorkplaceHeadquartersManager : IWorkplaceHeadquartersService
    {
        IWorkplaceHeadquartersDal _workplaceHeadquartersDal;

        public WorkplaceHeadquartersManager(IWorkplaceHeadquartersDal workplaceHeadquartersDal)
        {
            _workplaceHeadquartersDal = workplaceHeadquartersDal;
        }

        public IResult Add(WorkplaceHeadquarters entity)
        {
            _workplaceHeadquartersDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(WorkplaceHeadquarters entity)
        {
            _workplaceHeadquartersDal.Add(entity);
            return new SuccessResult();
        }

        public IDataResult<List<WorkplaceHeadquarters>> GetAll()
        {
            return new SuccessDataResult<List<WorkplaceHeadquarters>>(_workplaceHeadquartersDal.GetAll());
        }

        public IDataResult<WorkplaceHeadquarters> GetById(int workplaceHeadquartersId)
        {
            return new SuccessDataResult<WorkplaceHeadquarters>(_workplaceHeadquartersDal.Get(p => p.GenelMudurlukId == workplaceHeadquartersId));
        }

        public IResult Update(WorkplaceHeadquarters entity)
        {
            _workplaceHeadquartersDal.Update(entity);
            return new SuccessResult();
        }
    }
}
