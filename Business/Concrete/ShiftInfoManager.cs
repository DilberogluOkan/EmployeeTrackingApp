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
    public class ShiftInfoManager : IShiftInfoService
    {
        IShiftInfoDal _shiftInfoDal;

        public ShiftInfoManager(IShiftInfoDal shiftInfoDal)
        {
            _shiftInfoDal = shiftInfoDal;
        }

        public IDataResult<List<ShiftInfo>> GetAll()
        {
            return new SuccessDataResult<List<ShiftInfo>>(_shiftInfoDal.GetAll());
        }
    }
}
