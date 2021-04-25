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
    public class ReasonForCriminalManager : IReasonForCriminalService
    {
        IReasonForCriminalDal _reasonForCriminalDal;

        public ReasonForCriminalManager(IReasonForCriminalDal reasonForCriminalDal)
        {
            _reasonForCriminalDal = reasonForCriminalDal;
        }

        public IResult Add(ReasonForCriminal reasonForCriminal)
        {
            _reasonForCriminalDal.Add(reasonForCriminal);
            return new SuccessResult();
        }

        public IResult Delete(ReasonForCriminal reasonForCriminal)
        {
            _reasonForCriminalDal.Delete(reasonForCriminal);
            return new SuccessResult();
        }

        public IDataResult<List<ReasonForCriminal>> GetAll()
        {
            return new SuccessDataResult<List<ReasonForCriminal>>(_reasonForCriminalDal.GetAll());
            
        }

        public IDataResult<ReasonForCriminal> GetById(int reasonForCriminalId)
        {
            return new SuccessDataResult<ReasonForCriminal>(_reasonForCriminalDal.Get(p => p.CezaNedenId == reasonForCriminalId));
        }

        public IResult Update(ReasonForCriminal reasonForCriminal)
        {
            _reasonForCriminalDal.Update(reasonForCriminal);
            return new SuccessResult();
        }
    }
}
