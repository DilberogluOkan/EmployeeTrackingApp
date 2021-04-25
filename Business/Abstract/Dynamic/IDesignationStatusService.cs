using Core.Utilities.Results;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Dynamic
{
    public interface IDesignationStatusService
    {
        IResult Add(DesignationStatus designationStatus);
       
        IResult Delete(DesignationStatus designationStatus);
        IResult Update(DesignationStatus designationStatus);
        IDataResult<DesignationStatus> GetById(int designationStatusId);
      
        IDataResult<List<DesignationStatus>> GetAll();
    }
}
