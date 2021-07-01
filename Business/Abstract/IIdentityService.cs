using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
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
        IDataResult<List<Identity>> GetAllByAge(int YasBaslangic,int YasBitis);
       
        IDataResult<List<PersonDto>> GetPersonDetails(string id);
        IDataResult<List<PersonGeneralDto>> GetPersonGeneralDetails(int id);
        IDataResult<List<PersonIndividualDto>> GetPersonIndividualDtoDetails(int id);
        IDataResult<List<PersonWorkplaceDto>> GetPersonWorkplaceDtoDetails(int id);
      
        IDataResult<List<PersonTradeUnionInfoDto>> GetPersonTradeUnionInfoDtoDetails(int id);

        IDataResult<List<FilterQueryDto>> GetFilterQueryDetails(FilterQueryDto filterQueryDto);

        IResult Add(Identity identity);
        IResult Delete(Identity identity);
        IResult Update(Identity identity);
       
        IDataResult<Identity> GetById(int identityId);
        IDataResult<List<Identity>> GetGenderCount(int genderId);
        IDataResult<List<Identity>> GetAgeCount();
        IDataResult<List<Identity>> GetCurrentStatuCount(int currentStatusId);
        IDataResult<List<Identity>> GetBytc(string tc);
        IDataResult<List<Identity>> GetAll();
        
        IDataResult<List<Identity>>EngineerPersonCount();

        IDataResult<List<Identity>> AfgmForCount();
        IDataResult<List<Identity>> AsalForCount();
        IDataResult<List<Identity>> AsfatForCount();
        IDataResult<List<Identity>> AshgmForCount();
        IDataResult<List<Identity>> DzkkForCount();
        IDataResult<List<Identity>> GnkurForCount();
        IDataResult<List<Identity>> HgmForCount();
        IDataResult<List<Identity>> HvkkForCount();
        IDataResult<List<Identity>> KkkForCount();
        IDataResult<List<Identity>> LgmForCount();
        IDataResult<List<Identity>> MsuForCount();
        IDataResult<List<Identity>> TedgmForCount();
        IDataResult<List<Identity>> TgmForCount();
        IDataResult<List<Identity>> YhgmForCount();
        IDataResult<List<Identity>> WorkplaceCount(int id);
    }
}
