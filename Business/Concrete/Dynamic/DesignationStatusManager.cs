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
    public class DesignationStatusManager : IDesignationStatusService
    {
        IDesignationStatusDal _designationStatusDal;

        public DesignationStatusManager(IDesignationStatusDal designationStatusDal)
        {
            _designationStatusDal = designationStatusDal;
        }

        public IResult Add(DesignationStatus designationStatus)
        {
            _designationStatusDal.Add(designationStatus);
            return new SuccessResult();
        }

        public IResult Delete(DesignationStatus designationStatus)
        {
            _designationStatusDal.Delete(designationStatus);
            return new SuccessResult();
        }

        public IDataResult<List<DesignationStatus>> GetAll()
        {
            return new SuccessDataResult<List<DesignationStatus>>(_designationStatusDal.GetAll());
        }

        public IDataResult<DesignationStatus> GetById(int designationStatusId)
        {
            return new SuccessDataResult<DesignationStatus>(_designationStatusDal.Get(p=>p.NakilDurumId==designationStatusId));
        }

        public IResult Update(DesignationStatus designationStatus)
        {
            _designationStatusDal.Update(designationStatus);
            return new SuccessResult();
        }
    }
}
