using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDailyWorkingTimeService
    {
        IDataResult<List<DailyWorkingTime>> GetAll();
        IDataResult<DailyWorkingTime> GetById(int id);
        IResult Add(DailyWorkingTime dailyWorkingTime);
        IResult Delete(DailyWorkingTime dailyWorkingTime);
        IResult Update(DailyWorkingTime dailyWorkingTime);
    }
}
