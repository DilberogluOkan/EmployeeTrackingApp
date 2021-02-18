using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIdentityService
    {
        
        IDataResult<List<Identity>> GetAllByIdentityId(int id);
        
       // IDataResult<List<DetailDto>> GetProductDetails();
       
        IResult Add(Identity identity);
        IResult Delete(Identity identity);
        IResult Update(Identity identity);
        IDataResult<Identity> GetById(int identityId);
        IDataResult<List<Identity>> GetAll();
    }
}
