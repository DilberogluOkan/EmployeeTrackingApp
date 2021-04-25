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

        public IResult Add(DailyWorkingTime dailyWorkingTime)
        {
            _dailyWorkingTimeDal.Add(dailyWorkingTime);
            return new SuccessResult();
        }

        public IResult Delete(DailyWorkingTime dailyWorkingTime)
        {
            _dailyWorkingTimeDal.Delete(dailyWorkingTime);
            return new SuccessResult();
        }

        public IDataResult<List<DailyWorkingTime>> GetAll()
        {
            return new SuccessDataResult<List<DailyWorkingTime>>(_dailyWorkingTimeDal.GetAll());
        }

        public IDataResult<DailyWorkingTime> GetById(int id)
        {
            return new SuccessDataResult<DailyWorkingTime>(_dailyWorkingTimeDal.Get(p => p.GunlukCalismaSureId == id));
        }

        public IResult Update(DailyWorkingTime dailyWorkingTime)
        {
            _dailyWorkingTimeDal.Update(dailyWorkingTime);
            return new SuccessResult();
        }
    }
}
