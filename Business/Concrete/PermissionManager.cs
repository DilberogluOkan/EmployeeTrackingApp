using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PermissionManager : IPermissionService
    {
        IPermissionDal _permissionDal;

        public PermissionManager(IPermissionDal permissionDal)
        {
            _permissionDal = permissionDal;
        }

        public IResult Add(Permission permission)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Permission permission)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Permission> Get(int permissionId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Permission>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Permission permission)
        {
            throw new NotImplementedException();
        }
    }
}
