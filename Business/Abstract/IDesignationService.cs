using Core.Utilities.Results;
using Entities.Concrete;
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
        IDataResult<Designation> Get(int designationId);
    }
}
