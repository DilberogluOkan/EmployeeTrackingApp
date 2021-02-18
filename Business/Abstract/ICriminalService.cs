using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICriminalService
    {
        IResult Add(Criminal criminal);
        IResult Delete(Criminal criminal);
        IResult Update(Criminal criminal);
        IDataResult<List<Criminal>> GetAll();
        IDataResult<Criminal> GetById(int criminalId);
        IDataResult<List<Criminal>> GetAllByIdentityId(int id);
    }
}
