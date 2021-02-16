using Business.Abstract;
using Business.Constants;
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
    public class IdentityManager : IIdentityService
    {
        IIdentityDal _identityDal;

        public IdentityManager(IIdentityDal identityDal)
        {
            _identityDal = identityDal;
        }

        public IResult Add(Identity identity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Identity identity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Identity>> GetAll()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll());
        }

        public IDataResult<Identity> GetById(int identityId)
        {
            
            return new SuccessDataResult<Identity>(_identityDal.Get(p=>p.KimlikId==identityId));
        }

        public IResult Update(Identity identity)
        {
            throw new NotImplementedException();
        }
    }
}
