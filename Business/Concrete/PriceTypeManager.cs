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
    public class PriceTypeManager : IPriceTypeService
    {
        IPriceTypeDal _priceTypeDal;

        public PriceTypeManager(IPriceTypeDal priceTypeDal)
        {
            _priceTypeDal = priceTypeDal;
        }

        public IDataResult<List<PriceType>> GetAll()
        {
            return new SuccessDataResult<List<PriceType>>(_priceTypeDal.GetAll());
        }
    }
}
