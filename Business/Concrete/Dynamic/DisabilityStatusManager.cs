using Business.Abstract;
using Business.Abstract.Dynamic;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Abstract.Dynamic;
using Entities.Concrete;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Dynamic
{
    public class DisabilityStatusManager : IDisabilityStatusService
    {
        IDisabilityStatusDal _disabilityStatusDal;

        public DisabilityStatusManager(IDisabilityStatusDal disabilityStatusDal)
        {
            _disabilityStatusDal = disabilityStatusDal;
        }

        public IResult Add(DisabilityStatus disabilityStatus)
        {
            _disabilityStatusDal.Add(disabilityStatus);
            return new SuccessResult();
        }

        public IResult Delete(DisabilityStatus disabilityStatus)
        {
            _disabilityStatusDal.Delete(disabilityStatus);
            return new SuccessResult();
        }

        public IDataResult<List<DisabilityStatus>> GetAll()
        {
            return new SuccessDataResult<List<DisabilityStatus>>(_disabilityStatusDal.GetAll());
        }

        public IDataResult<DisabilityStatus> GetById(int disabilityStatusId)
        {
            return new SuccessDataResult<DisabilityStatus>(_disabilityStatusDal.Get(p => p.OzelDurumId == disabilityStatusId));
        }

        public IDataResult<List<DisabilityStatus>> GetDisabilityCount()
        {
            return new SuccessDataResult<List<DisabilityStatus>>(_disabilityStatusDal.GetAll(p => p.OzelDurumId == 1));

        }

        public IResult Update(DisabilityStatus disabilityStatus)
        {
            _disabilityStatusDal.Update(disabilityStatus);
            return new SuccessResult();
        }
    }
}
