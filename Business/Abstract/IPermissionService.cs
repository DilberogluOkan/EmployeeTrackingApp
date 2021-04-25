using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPermissionService
    {
        IResult Add(Permission permission);
        IResult Delete(Permission permission);
        IResult Update(Permission permission);
        IDataResult<List<Permission>> GetAll();
        IDataResult<Permission> GetById(int permissionId);
        IDataResult<List<Permission>> GetAllByIdentityId(int id);
        IDataResult<List<PermissionDto>> GetPermissionDetails(int id);
    }
}
