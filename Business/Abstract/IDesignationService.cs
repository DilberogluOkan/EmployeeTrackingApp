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
    public interface IDesignationService
    {
        IResult Add(Designation designation);
        IResult Delete(Designation designation);
        IResult Update(Designation designation);
        IDataResult<List<Designation>> GetAll();
        IDataResult<Designation> GetById(int designationId);
        IDataResult<List<Designation>> GetAllByIdentityId(int id);
        IDataResult<List<DesignationDto>> GetDesignationDetails(int id);
    }
}
