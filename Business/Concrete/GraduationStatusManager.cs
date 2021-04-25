using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GraduationStatusManager : IGraduationStatusService
    {
        IGraduationStatusDal _graduationStatusDal;

        public GraduationStatusManager(IGraduationStatusDal graduationStatusDal)
        {
            _graduationStatusDal = graduationStatusDal;
        }

        public IDataResult<List<GraduationStatus>> GetAll()
        {
            return new SuccessDataResult<List<GraduationStatus>>(_graduationStatusDal.GetAll());
        }
    }
}
