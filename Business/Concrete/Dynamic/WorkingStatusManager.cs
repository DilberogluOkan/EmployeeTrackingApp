using Business.Abstract;
using Business.Abstract.Dynamic;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Dynamic
{
    public class WorkingStatusManager : IWorkingStatusService
    {
        IWorkingStatusDal _workingStatusDal;

        public WorkingStatusManager(IWorkingStatusDal workingStatusDal)
        {
            _workingStatusDal = workingStatusDal;
        }

        public IResult Add(WorkingStatus workingStatus)
        {
            _workingStatusDal.Add(workingStatus);
            return new SuccessResult();
        }

        public IResult Delete(WorkingStatus workingStatus)
        {
            _workingStatusDal.Delete(workingStatus);
            return new SuccessResult();
        }

        public IDataResult<List<WorkingStatus>> GetAll()
        {
            return new SuccessDataResult<List<WorkingStatus>>(_workingStatusDal.GetAll());
        }


        public IDataResult<WorkingStatus> GetById(int workingStatusId)
        {
            return new SuccessDataResult<WorkingStatus>(_workingStatusDal.Get(p=>p.IstihtamDurumId==workingStatusId));
        }

        public IResult Update(WorkingStatus workingStatus)
        {
            _workingStatusDal.Update(workingStatus);
            return new SuccessResult();
        }
    }
}
