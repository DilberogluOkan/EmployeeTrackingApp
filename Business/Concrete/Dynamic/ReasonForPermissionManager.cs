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
    public class ReasonForPermissionManager : IReasonForPermissionService
    {
        IReasonForPermissionDal _reasonForPermissionDal;

        public ReasonForPermissionManager(IReasonForPermissionDal reasonForPermissionDal)
        {
            _reasonForPermissionDal = reasonForPermissionDal;
        }

        public IResult Add(ReasonForPermission reasonForPermission)
        {
            _reasonForPermissionDal.Add(reasonForPermission);
            return new SuccessResult();
        }

        public IResult Delete(ReasonForPermission reasonForPermission)
        {
            _reasonForPermissionDal.Delete(reasonForPermission);
            return new SuccessResult();
        }

        public IDataResult<List<ReasonForPermission>> GetAll()
        {
            return new SuccessDataResult<List<ReasonForPermission>>(_reasonForPermissionDal.GetAll());
        }

        public IDataResult<ReasonForPermission> GetById(int reasonForPermissionId)
        {
            return new SuccessDataResult<ReasonForPermission>(_reasonForPermissionDal.Get(p => p.IzinNedenId == reasonForPermissionId));
        }

        public IResult Update(ReasonForPermission reasonForPermission)
        {
            _reasonForPermissionDal.Update(reasonForPermission);
            return new SuccessResult();
        }
    }
}
