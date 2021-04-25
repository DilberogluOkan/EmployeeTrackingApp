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
    public class ReasonForTemporaryDutyManager : IReasonForTemporaryDutyService
    {
        IReasonForTemporaryDutyDal _reasonForTemporaryDutyDal;

        public ReasonForTemporaryDutyManager(IReasonForTemporaryDutyDal reasonForTemporaryDutyDal)
        {
            _reasonForTemporaryDutyDal = reasonForTemporaryDutyDal;
        }

        public IResult Add(ReasonForTemporaryDuty reasonForTemporaryDuty)
        {
            _reasonForTemporaryDutyDal.Add(reasonForTemporaryDuty);
            return new SuccessResult();

        }

        public IResult Delete(ReasonForTemporaryDuty reasonForTemporaryDuty)
        {
            _reasonForTemporaryDutyDal.Delete(reasonForTemporaryDuty);
            return new SuccessResult();
        }

        public IDataResult<List<ReasonForTemporaryDuty>> GetAll()
        {
            return new SuccessDataResult<List<ReasonForTemporaryDuty>>(_reasonForTemporaryDutyDal.GetAll());
        }

        public IDataResult<ReasonForTemporaryDuty> GetById(int reasonForTemporaryDutyId)
        {
            return new SuccessDataResult<ReasonForTemporaryDuty>(_reasonForTemporaryDutyDal.Get(p => p.GeciciGorevNedenId == reasonForTemporaryDutyId));
        }

        public IResult Update(ReasonForTemporaryDuty reasonForTemporaryDuty)
        {
            _reasonForTemporaryDutyDal.Update(reasonForTemporaryDuty);
            return new SuccessResult();
        }
    }
}
