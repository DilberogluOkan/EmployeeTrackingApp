using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DailyWorkingTimeManager : IDailyWorkingTimeService
    {
        IDailyWorkingTimeDal _dailyWorkingTimeDal;

        public DailyWorkingTimeManager(IDailyWorkingTimeDal dailyWorkingTimeDal)
        {
            _dailyWorkingTimeDal = dailyWorkingTimeDal;
        }

        public IDataResult<List<DailyWorkingTime>> GetAll()
        {
            return new SuccessDataResult<List<DailyWorkingTime>>(_dailyWorkingTimeDal.GetAll());
        }
    }
}
