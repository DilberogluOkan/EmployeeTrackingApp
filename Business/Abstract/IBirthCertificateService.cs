using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBirthCertificateService
    {
        IResult Add(BirthCertificate birthCertificate);
        IResult Delete(BirthCertificate birthCertificate);
        IResult Update(BirthCertificate birthCertificate);
        IDataResult<List<BirthCertificate>> GetAll();
        IDataResult<BirthCertificate> Get(int birthCertificateId);
        IDataResult<BirthCertificate> GetById(int birthCertificateId);
    }
}
