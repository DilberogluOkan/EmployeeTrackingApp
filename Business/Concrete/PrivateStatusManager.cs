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
    public class PrivateStatusManager : IPrivateStatusService
    {
        IPrivateStatusDal _privataStatusDal;

        public PrivateStatusManager(IPrivateStatusDal privataStatusDal)
        {
            _privataStatusDal = privataStatusDal;
        }

        public IResult Add(PrivateStatus entity)
        {
            _privataStatusDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(PrivateStatus entity)
        {
            _privataStatusDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<PrivateStatus>> GetAll()
        {
            return new SuccessDataResult<List<PrivateStatus>>(_privataStatusDal.GetAll());
        }

        public IDataResult<PrivateStatus> GetById(int privateStatusId)
        {
            return new SuccessDataResult<PrivateStatus>(_privataStatusDal.Get(p => p.OzelDurumId == privateStatusId));
        }

        public IResult Update(PrivateStatus entity)
        {
            _privataStatusDal.Update(entity);
            return new SuccessResult();
        }
    }
}
