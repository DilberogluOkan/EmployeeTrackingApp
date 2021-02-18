using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAwardService
    {
        IResult Add(Award award);
        IResult Delete(Award award);
        IResult Update(Award award);
        IDataResult<Award> GetById(int awardId);
        IDataResult<List<Award>> GetAll();
        IDataResult<List<Award>> GetAllByIdentityId(int id);
    }
}
