using Business.Abstract;
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
    public class BirthCertificateManager : IBirthCertificateService
    {
        IBirthCertificateDal _birthCertificateDal;

        public BirthCertificateManager(IBirthCertificateDal birthCertificateDal)
        {
            _birthCertificateDal = birthCertificateDal;
        }

        public IResult Add(BirthCertificate birthCertificate)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(BirthCertificate birthCertificate)
        {
            throw new NotImplementedException();
        }

        public IDataResult<BirthCertificate> Get(int birthCertificateId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BirthCertificate>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<BirthCertificate> GetById(int birthCertificateId)
        {
            return new SuccessDataResult<BirthCertificate>(_birthCertificateDal.Get(p => p.PersonelNufusId == birthCertificateId));
        }

        public IResult Update(BirthCertificate birthCertificate)
        {
            _birthCertificateDal.Update(birthCertificate);
            return new SuccessResult();
        }
    }
}
