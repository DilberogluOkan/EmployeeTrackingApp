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
    public class DesignationApprovalManager : IDesignationApprovalService
    {
        IDesignationApprovalDal _designationApprovalDal;

        public DesignationApprovalManager(IDesignationApprovalDal designationApprovalDal)
        {
            _designationApprovalDal = designationApprovalDal;
        }

        public IResult Add(DesignationApproval entity)
        {
            _designationApprovalDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(DesignationApproval entity)
        {
            _designationApprovalDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<DesignationApproval>> GetAll()
        {
            return new SuccessDataResult<List<DesignationApproval>>(_designationApprovalDal.GetAll());
        }

        public IDataResult<DesignationApproval> GetById(int designationApprovalId)
        {
            return new SuccessDataResult<DesignationApproval>(_designationApprovalDal.Get(p => p.OnayId == designationApprovalId));
        }

        public IResult Update(DesignationApproval entity)
        {
            _designationApprovalDal.Update(entity);
            return new SuccessResult();
        }
    }
}
