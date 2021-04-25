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
    public class PermissionTypeManager : IPermissionTypeService
    {
        IPermissionTypeDal _permissionTypeDal;

        public PermissionTypeManager(IPermissionTypeDal permissionTypeDal)
        {
            _permissionTypeDal = permissionTypeDal;
        }

        public IResult Add(PermissionType permissionType)
        {
            _permissionTypeDal.Add(permissionType);
            return new SuccessResult();
        }

        public IResult Delete(PermissionType permissionType)
        {
            _permissionTypeDal.Delete(permissionType);
            return new SuccessResult();

        }

        public IDataResult<List<PermissionType>> GetAll()
        {
            return new SuccessDataResult<List<PermissionType>>(_permissionTypeDal.GetAll());
        }

        public IDataResult<PermissionType> GetById(int permissionTypeId)
        {
            return new SuccessDataResult<PermissionType>(_permissionTypeDal.Get(p => p.IzinTurId == permissionTypeId));
        }

        public IResult Update(PermissionType permissionType)
        {
            _permissionTypeDal.Update(permissionType);
            return new SuccessResult();

        }
    }
}
