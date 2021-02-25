using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWorkplaceService
    {
        IResult Add(Workplace workplace);
        IResult Delete(Workplace workplace);
        IResult Update(Workplace workplace);
        IDataResult<Workplace> GetById(int workplaceId);
        IDataResult<List<Workplace>> GetAll();
        IDataResult<List<Workplace>> GetAllByIdentityId(int id);
    }
}
