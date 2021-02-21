using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AwardManager : IAwardService
    {
        IAwardDal _awardDal;

        public AwardManager(IAwardDal AwardDal)
        {
            _awardDal = AwardDal;
        }

        public IResult Add(Award award)
        {
            if (award.OdulVerenAmirAdi==null)
            {
                return new ErrorResult(Messages.AddNegative);
            }
            _awardDal.Add(award);
            return new SuccessResult(Messages.AddPositive);
        }

        public IResult Delete(Award award)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Award>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Award>> GetAllByIdentityId(int id)
        {
            return new SuccessDataResult<List<Award>>(_awardDal.GetAll(p => p.PersonelKimlikId == id));
        }

        public IDataResult<Award> GetById(int awardId)
        {
            return new SuccessDataResult<Award>(_awardDal.Get(p => p.PersonelOdulId == awardId));

        }

        public IResult Update(Award award)
        {
            _awardDal.Update(award);
            return new SuccessResult();
        }
    }
}
