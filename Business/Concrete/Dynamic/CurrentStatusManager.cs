using Business.Abstract.Dynamic;
using Core.Utilities.Results;
using DataAccess.Abstract.Dynamic;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Dynamic
{
    public class CurrentStatusManager : ICurrentStatusService
    {
        ICurrentStatusDal _currentStatusDal;

        public CurrentStatusManager(ICurrentStatusDal currentStatusDal)
        {
            _currentStatusDal = currentStatusDal;
        }

        public IResult Add(CurrentStatus currentStatus)
        {
            _currentStatusDal.Add(currentStatus);
            return new SuccessResult();
        }

        public IResult Delete(CurrentStatus currentStatus)
        {
            _currentStatusDal.Delete(currentStatus);
            return new SuccessResult();
        }

        public IDataResult<List<CurrentStatus>> GetAll()
        {
            return new SuccessDataResult<List<CurrentStatus>>(_currentStatusDal.GetAll());
        }

        public IDataResult<CurrentStatus> GetById(int currentStatusId)
        {
            return new SuccessDataResult<CurrentStatus>(_currentStatusDal.Get(p => p.MevcutStatuId == currentStatusId));
        }

        public IResult Update(CurrentStatus currentStatus)
        {
            _currentStatusDal.Update(currentStatus);
            return new SuccessResult();
        }
    }
}
