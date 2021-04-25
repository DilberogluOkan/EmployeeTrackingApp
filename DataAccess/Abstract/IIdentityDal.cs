using Core.DataAccess;
using Entities.Concrete;

using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IIdentityDal:IEntityRepository<Identity>

    {
        List<PersonDto> GetPersonDetails(Expression<Func<Identity,bool>> filter=null);
        List<PersonWorkplaceDto> GetPersonWorkplaceDtoDetails(Expression<Func<Identity,bool>> filter=null);
        List<PersonGeneralDto> GetPersonGeneralDetails(Expression<Func<Identity, bool>> filter = null);
        List<PersonIndividualDto> GetPersonIndividualDtoDetails(Expression<Func<Identity, bool>> filter = null);
      
        List<PersonTradeUnionInfoDto> GetPersonTradeUnionInfoDetails(Expression<Func<Identity, bool>> filter = null);
        //List<Identity> GetPersonCount(Expression<Func<Identity, bool>> filter = null);
        //List<Identity> GetWomanCount(Expression<Func<Identity, bool>> filter = null);
    }
}
