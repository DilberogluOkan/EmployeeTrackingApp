using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MilitaryStatusManager : IMilitaryStatusService
    {
        IMilitaryStatusDal _militaryStatusDal;

        public MilitaryStatusManager(IMilitaryStatusDal militaryStatusDal)
        {
            _militaryStatusDal = militaryStatusDal;
        }

        public IResult Add(MilitaryStatus entity)
        {
            _militaryStatusDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(MilitaryStatus entity)
        {
            _militaryStatusDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<MilitaryStatus> Get(int militaryStatusId)
        {
            return new SuccessDataResult<MilitaryStatus>(_militaryStatusDal.Get(p=>p.AskerlikDurumId==militaryStatusId));
        }

        public IDataResult<List<MilitaryStatus>> GetAll()
        {
            return new SuccessDataResult<List<MilitaryStatus>>(_militaryStatusDal.GetAll());
        }

        public IResult Update(MilitaryStatus entity)
        {
            _militaryStatusDal.Update(entity);
            return new SuccessResult();
        }
    }
}
