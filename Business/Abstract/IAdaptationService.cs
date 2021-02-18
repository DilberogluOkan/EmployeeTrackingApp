using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdaptationService
    {
        IResult Add(Adaptation adaptation);
        IResult Delete(Adaptation adaptation);
        IResult Update(Adaptation adaptation);
        IDataResult<Adaptation> GetById(int adaptationId);
        IDataResult<List<Adaptation>> GetAll();
        IDataResult<List<Adaptation>> GetAllByIdentityId(int id);
    }
}
