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
    public class DisabilityStatusManager : IDisabilityStatusService
    {
        IDisabilityStatusDal _disabilityStatusDal;

        public DisabilityStatusManager(IDisabilityStatusDal disabilityStatusDal)
        {
            _disabilityStatusDal = disabilityStatusDal;
        }

        public IDataResult<List<DisabilityStatus>> GetAll()
        {
            return new SuccessDataResult<List<DisabilityStatus>>(_disabilityStatusDal.GetAll());
        }
    }
}
