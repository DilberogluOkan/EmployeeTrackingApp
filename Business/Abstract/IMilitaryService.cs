using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMilitaryService
    {
        IResult Add(Military military);
        IResult Delete(Military military);
        IResult Update(Military military);
        IDataResult<List<Military>> GetAll();
        IDataResult<Military> GetById(int militaryId);
        IDataResult<List<Military>> GetAllById(int militaryPersonId);
    }
}
