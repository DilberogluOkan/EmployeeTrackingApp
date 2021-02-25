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
    public class WorkingStatusManager : IWorkingStatusService
    {
        IWorkingStatusDal _workingStatusDal;

        public WorkingStatusManager(IWorkingStatusDal workingStatusDal)
        {
            _workingStatusDal = workingStatusDal;
        }

        public IDataResult<List<WorkingStatus>> GetAll()
        {
            return new SuccessDataResult<List<WorkingStatus>>(_workingStatusDal.GetAll());
        }
    }
}
