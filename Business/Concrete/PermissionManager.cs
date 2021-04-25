using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
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
            _permissionDal.Add(permission);
            return new SuccessResult();
        }

        public IResult Delete(Permission permission)
        {
            throw new NotImplementedException();
        }

        
        public IDataResult<List<Permission>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Permission>> GetAllByIdentityId(int id)
        {
            return new SuccessDataResult<List<Permission>>(_permissionDal.GetAll(p => p.PersonelKimlikId == id));
        }

        public IDataResult<Permission> GetById(int permissionId)
        {
            return new SuccessDataResult<Permission>(_permissionDal.Get(p => p.PersonelIzinId == permissionId));
        }

        public IDataResult<List<PermissionDto>> GetPermissionDetails(int id)
        {
            return new SuccessDataResult<List<PermissionDto>>(_permissionDal.GetPermissionDetails(p => p.PersonelKimlikId == id));
        }

        public IResult Update(Permission permission)
        {
            _permissionDal.Update(permission);
            return new SuccessResult();
        }
    }
}
