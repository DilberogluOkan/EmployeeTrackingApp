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
        IAwardDal _AwardDal;

        public AwardManager(IAwardDal AwardDal)
        {
            _AwardDal = AwardDal;
        }

        public IResult Add(Award award)
        {
            if (award.OdulVerenAmirAdı==null)
            {
                return new ErrorResult(Messages.AddNegative);
            }
            _AwardDal.Add(award);
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

        public IDataResult<Award> GetById(int awardId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Award award)
        {
            throw new NotImplementedException();
        }
    }
}
