using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Dynamic
{
    public interface IDesignationApprovalService:IServiceRepository<DesignationApproval>
    {
        IDataResult<DesignationApproval> GetById(int designationApprovalId);
        IDataResult<List<DesignationApproval>> GetAll();
    }
}
