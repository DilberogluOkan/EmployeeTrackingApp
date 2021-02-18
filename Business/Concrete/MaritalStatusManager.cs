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
    public class MaritalStatusManager : IMaritalStatusService
    {
        IMaritalStatusDal _maritalStatusDal;

        public MaritalStatusManager(IMaritalStatusDal maritalStatusDal)
        {
            _maritalStatusDal = maritalStatusDal;
        }

        public IDataResult<List<MaritalStatus>> GetAll()
        {
            return new SuccessDataResult<List<MaritalStatus>>(_maritalStatusDal.GetAll());
        }
    }
}
