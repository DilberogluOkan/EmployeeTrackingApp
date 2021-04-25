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
    public interface IWorkingPriceService
    {
        IResult Add(WorkingPrice workingPrice);
        IResult Delete(WorkingPrice workingPrice);
        IResult Update(WorkingPrice workingPrice);
        IDataResult<WorkingPrice> GetById(int workingPriceId);
        IDataResult<List<PriceDto>> GetPriceDetails(int id);
        IDataResult<List<WorkingPrice>> GetAll();
        IDataResult<List<WorkingPrice>> GetAllByIdentityId(int id);
    }
}
