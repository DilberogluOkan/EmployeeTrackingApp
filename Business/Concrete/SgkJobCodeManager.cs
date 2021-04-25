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
    public class SgkJobCodeManager : ISgkJobCodeService
    {
        ISgkJobCodeDal _sgkJobCodeDal;

        public SgkJobCodeManager(ISgkJobCodeDal sgkJobCodeDal)
        {
            _sgkJobCodeDal = sgkJobCodeDal;
        }

        public IResult Add(SgkJobCode entity)
        {
            _sgkJobCodeDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(SgkJobCode entity)
        {
            _sgkJobCodeDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<SgkJobCode>> GetAll()
        {
            return new SuccessDataResult<List<SgkJobCode>>(_sgkJobCodeDal.GetAll());
        }

        public IDataResult<SgkJobCode> GetById(int sgkJobCodeId)
        {
            return new SuccessDataResult<SgkJobCode>(_sgkJobCodeDal.Get(p=>p.SgkMeslekKodId==sgkJobCodeId));
        }

        public IResult Update(SgkJobCode entity)
        {
            _sgkJobCodeDal.Update(entity);
            return new SuccessResult();
        }
    }
}
