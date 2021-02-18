using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPromotionService
    {
        IResult Add(Promotion promotion);
        IResult Delete(Promotion promotion);
        IResult Update(Promotion promotion);
        IDataResult<List<Promotion>> GetAll();
        IDataResult<Promotion> GetById(int promotionId);
        IDataResult<List<Promotion>> GetAllByIdentityId(int id);
    }
}
