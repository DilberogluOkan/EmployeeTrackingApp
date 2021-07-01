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
    public class TisJobCodeManager : ITisJobCodeService
    {
        ITisJobCodeDal _tisJobCodeDal;

        public TisJobCodeManager(ITisJobCodeDal tisJobCodeDal)
        {
            _tisJobCodeDal = tisJobCodeDal;
        }

        public IResult Add(TisJobCode entity)
        {
            _tisJobCodeDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(TisJobCode entity)
        {
            _tisJobCodeDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<TisJobCode>> GetAll()
        {
            return new SuccessDataResult<List<TisJobCode>>(_tisJobCodeDal.GetAll());
        }

        public IDataResult<TisJobCode> GetById(int tisJobCodeId)
        {
            return new SuccessDataResult<TisJobCode>(_tisJobCodeDal.Get(p => p.TisMeslekKodId == tisJobCodeId));
        }

        public IResult Update(TisJobCode entity)
        {
            _tisJobCodeDal.Update(entity);
            return new SuccessResult();
        }
    }
}
