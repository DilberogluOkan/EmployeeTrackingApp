using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WorkingPriceManager : IWorkingPriceService
    {
        IWorkingPriceDal _workingPriceDal;

        public WorkingPriceManager(IWorkingPriceDal workingPriceDal)
        {
            _workingPriceDal = workingPriceDal;
        }

        public IResult Add(WorkingPrice workingPrice)
        {
            _workingPriceDal.Add(workingPrice);
            return new SuccessResult();
        }

        public IResult Delete(WorkingPrice workingPrice)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<WorkingPrice>> GetAll()
        {
            return new SuccessDataResult<List<WorkingPrice>>(_workingPriceDal.GetAll());
        }

        public IDataResult<List<WorkingPrice>> GetAllByIdentityId(int id)
        {
            return new SuccessDataResult<List<WorkingPrice>>(_workingPriceDal.GetAll(p=>p.PersonelKimlikId==id));
        }

        public IDataResult<WorkingPrice> GetById(int workingPriceId)
        {
            return new SuccessDataResult<WorkingPrice>(_workingPriceDal.Get(p => p.CalismaUcretBilgiId == workingPriceId));
        }

        public IDataResult<List<PriceDto>> GetPriceDetails(int id)
        {
            return new SuccessDataResult<List<PriceDto>>(_workingPriceDal.GetPriceDetails(p=>p.PersonelKimlikId==id));
        }

        public IResult Update(WorkingPrice workingPrice)
        {
            _workingPriceDal.Update(workingPrice);
            return new SuccessResult();
        }
    }
}
