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
    public class PriceGradeRiseManager : IPriceGradeRiseService
    {
        IPriceGradeRiseDal _priceGradeRiseDal;

        public PriceGradeRiseManager(IPriceGradeRiseDal priceGradeRiseDal)
        {
            _priceGradeRiseDal = priceGradeRiseDal;
        }

        public IDataResult<List<PriceGradeRise>> GetAll()
        {
            return new SuccessDataResult<List<PriceGradeRise>>(_priceGradeRiseDal.GetAll());
        }
    }
}
