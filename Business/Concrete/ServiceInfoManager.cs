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
    public class ServiceInfoManager : IServiceInfoService
    {
        IServiceInfoDal _serviceInfoDal;

        public ServiceInfoManager(IServiceInfoDal serviceInfoDal)
        {
            _serviceInfoDal = serviceInfoDal;
        }

        public IDataResult<List<ServiceInfo>> GetAll()
        {
            return new SuccessDataResult<List<ServiceInfo>>(_serviceInfoDal.GetAll());
        }
    }
}
