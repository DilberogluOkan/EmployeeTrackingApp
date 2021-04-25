using Core.Utilities.Results;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Dynamic
{
    public interface IPermissionTypeService
    {
        IResult Add(PermissionType permissionType);
        IResult Delete(PermissionType permissionType);
        IResult Update(PermissionType permissionType);
        IDataResult<PermissionType> GetById(int permissionTypeId);
        IDataResult<List<PermissionType>> GetAll();
       
    }
}
