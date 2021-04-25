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
    public class ReasonForDesignationManager : IReasonForDesignationService
    {
        IReasonForDesignationDal _reasonForDesignationDal;

        public ReasonForDesignationManager(IReasonForDesignationDal reasonForDesignationDal)
        {
            _reasonForDesignationDal = reasonForDesignationDal;
        }

        public IResult Add(ReasonForDesignation reasonForDesignation)
        {
            _reasonForDesignationDal.Add(reasonForDesignation);
            return new SuccessResult();
        }

        public IResult Delete(ReasonForDesignation reasonForDesignation)
        {
            _reasonForDesignationDal.Delete(reasonForDesignation);
            return new SuccessResult();
        }

        public IDataResult<List<ReasonForDesignation>> GetAll()
        {
            return new SuccessDataResult<List<ReasonForDesignation>>(_reasonForDesignationDal.GetAll());
        }

        public IDataResult<ReasonForDesignation> GetById(int reasonForDesignationId)
        {
            return new SuccessDataResult<ReasonForDesignation>(_reasonForDesignationDal.Get(p => p.AtamaIstegiNedenId == reasonForDesignationId));
        }

        public IResult Update(ReasonForDesignation reasonForDesignation)
        {
            _reasonForDesignationDal.Update(reasonForDesignation);
            return new SuccessResult();
        }
    }
}
