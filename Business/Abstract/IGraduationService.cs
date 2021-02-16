using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGraduationService
    {
        IResult Add(Graduation graduation);
        IResult Delete(Graduation graduation);
        IResult Update(Graduation graduation);
        IDataResult<List<Graduation>> GetAll();
        IDataResult<Graduation> Get(int graduationId);
    }
}
