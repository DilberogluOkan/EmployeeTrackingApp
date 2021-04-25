using Core.Utilities.Results;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Dynamic
{
    public interface IReasonForPermissionService
    {
        IResult Add(ReasonForPermission reasonForPermission);
        IResult Delete(ReasonForPermission reasonForPermission);
        IResult Update(ReasonForPermission reasonForPermission);
        IDataResult<ReasonForPermission> GetById(int reasonForPermissionId);
        IDataResult<List<ReasonForPermission>> GetAll();
    }
}
