using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
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
            _identityDal.Add(identity);
            return new SuccessResult();
        }

        public IResult Delete(Identity identity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Identity>> GetAgeCount()
        {
            var sonuc = DateTime.Now.AddYears(-49);
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.DogumTarihi.Value <= sonuc));
        }

        public IDataResult<List<Identity>> GetAll()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll());
        }

        public IDataResult<List<Identity>> GetAllByIdentityId(int id)
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.PersonelKimlikId == id));
        }

        public IDataResult<Identity> GetById(int identityId)
        {

            return new SuccessDataResult<Identity>(_identityDal.Get(p => p.PersonelKimlikId == identityId));
        }

        public IDataResult<List<Identity>> GetBytc(string tc)
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.TcKimlikNo.Contains(tc)));
        }

        public IDataResult<List<Identity>> GetCurrentStatuCount(int currentStatusId)
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.MevcutStatuId == currentStatusId));
        }

        public IDataResult<List<Identity>> GetGenderCount(int genderId)
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.CinsiyetId == genderId));
        }

        public IDataResult<List<PersonDto>> GetPersonDetails(string id)
        {
            return new SuccessDataResult<List<PersonDto>>(_identityDal.GetPersonDetails(p => p.TcKimlikNo.Contains(id)));
        }

        public IDataResult<List<PersonGeneralDto>> GetPersonGeneralDetails(int id)
        {
            return new SuccessDataResult<List<PersonGeneralDto>>(_identityDal.GetPersonGeneralDetails(p => p.PersonelKimlikId == id));
        }

        public IDataResult<List<PersonIndividualDto>> GetPersonIndividualDtoDetails(int id)
        {
            return new SuccessDataResult<List<PersonIndividualDto>>(_identityDal.GetPersonIndividualDtoDetails(p => p.PersonelKimlikId == id));
        }

        public IDataResult<List<PersonTradeUnionInfoDto>> GetPersonTradeUnionInfoDtoDetails(int id)
        {
            return new SuccessDataResult<List<PersonTradeUnionInfoDto>>(_identityDal.GetPersonTradeUnionInfoDetails(p => p.PersonelKimlikId == id));

        }

        public IDataResult<List<PersonWorkplaceDto>> GetPersonWorkplaceDtoDetails(int id)
        {
            return new SuccessDataResult<List<PersonWorkplaceDto>>(_identityDal.GetPersonWorkplaceDtoDetails(p => p.PersonelKimlikId == id));

        }

        public IResult Update(Identity identity)
        {
            _identityDal.Update(identity);
            return new SuccessResult();

        }
        public IDataResult<List<Identity>> AfgmForCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId <= 26));
        }
        public IDataResult<List<Identity>> KkkForCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId > 229 & p.IsYeriId < 271));
        }

        public IDataResult<List<Identity>> AsalForCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId > 26 & p.IsYeriId < 194));
        }

        public IDataResult<List<Identity>> AsfatForCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId == 353));
        }

        public IDataResult<List<Identity>> AshgmForCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId > 193 & p.IsYeriId < 197));
        }

        public IDataResult<List<Identity>> DzkkForCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId > 302 & p.IsYeriId < 353));
        }

        public IDataResult<List<Identity>> GnkurForCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId > 296 & p.IsYeriId < 303));
        }

        public IDataResult<List<Identity>> HgmForCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId == 197));
        }

        public IDataResult<List<Identity>> HvkkForCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId > 270 & p.IsYeriId < 297));
        }

        public IDataResult<List<Identity>> LgmForCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId > 197 & p.IsYeriId < 207));
        }

        public IDataResult<List<Identity>> MsuForCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId > 206 & p.IsYeriId < 212));
        }

        public IDataResult<List<Identity>> TedgmForCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId > 211 & p.IsYeriId < 221));
        }

        public IDataResult<List<Identity>> TgmForCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId > 220 & p.IsYeriId < 224));
        }

        public IDataResult<List<Identity>> YhgmForCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId > 223 & p.IsYeriId < 230));
        }

        public IDataResult<List<Identity>> EngineerPersonCount()
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.TisMeslekKolId == "B999" || p.TisMeslekKolId == "E999" ||
                                                                                  p.TisMeslekKolId == "E999" || p.TisMeslekKolId == "E998" ||
                                                                                  p.TisMeslekKolId == "E997" || p.TisMeslekKolId == "F999" || p.TisMeslekKolId == "G999" ||
                                                                                  p.TisMeslekKolId == "G998" || p.TisMeslekKolId == "H999" || p.TisMeslekKolId == "K998" ||
                                                                                  p.TisMeslekKolId == "M999" || p.TisMeslekKolId == "M998" || p.TisMeslekKolId == "T999"));
        }

        public IDataResult<List<Identity>> WorkplaceCount(int id)
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId==id));

        }
    }
}                                                                              