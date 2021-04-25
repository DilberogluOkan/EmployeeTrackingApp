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
    public class ProvinceManager : IProvinceService
    {
        IProvinceDal _provinceDal;

        public ProvinceManager(IProvinceDal provinceDal)
        {
            _provinceDal = provinceDal;
        }

        public IResult Add(Province entity)
        {
            _provinceDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Province entity)
        {
            _provinceDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Province>> GetAll()
        {
            return new SuccessDataResult<List<Province>>(_provinceDal.GetAll());
        }

        public IDataResult<Province> GetById(int proviceId)
        {
            return new SuccessDataResult<Province>(_provinceDal.Get(p => p.IlId == proviceId));
        }

        public IResult Update(Province entity)
        {
            _provinceDal.Update(entity);
            return new SuccessResult();
        }
    }
}
