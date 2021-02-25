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
    public class AdminStatusManager : IAdminStatusService
    {
        IAdminStatusDal _adminStatusDal;

        public AdminStatusManager(IAdminStatusDal adminStatusDal)
        {
            _adminStatusDal = adminStatusDal;
        }

        public IDataResult<List<AdminStatus>> GetAll()
        {
            return new SuccessDataResult<List<AdminStatus>>(_adminStatusDal.GetAll());
        }
    }
}
