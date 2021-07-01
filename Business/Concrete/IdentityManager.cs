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
        public IResult Update(Identity identity)
        {
            _identityDal.Update(identity);
            return new SuccessResult();

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
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.PersonelKimlikId != id));
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
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.TisMeslekKolId == 336 || p.TisMeslekKolId == 341 ||
                                                                                  p.TisMeslekKolId == 337 || p.TisMeslekKolId == 342 ||
                                                                                  p.TisMeslekKolId == 338 || p.TisMeslekKolId == 346 || p.TisMeslekKolId == 354 ||
                                                                                  p.TisMeslekKolId == 339 || p.TisMeslekKolId == 352 || p.TisMeslekKolId == 360 ||
                                                                                  p.TisMeslekKolId == 340 || p.TisMeslekKolId == 353 || p.TisMeslekKolId == 361));
        }

        public IDataResult<List<Identity>> WorkplaceCount(int id)
        {
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll(p => p.IsYeriId == id));

        }
        public IDataResult<List<Identity>> GetAllByAge(int YasBaslangic, int YasBitis)
        {
            var baslangicYıl = DateTime.Now.AddYears(-YasBaslangic);
            var bitisYıl = DateTime.Now.AddYears(-YasBitis);
            return new SuccessDataResult<List<Identity>>(_identityDal.GetAll
                                                     (p => p.DogumTarihi.Value <= baslangicYıl && p.DogumTarihi.Value >= bitisYıl));

        }

        public IDataResult<List<FilterQueryDto>> GetFilterQueryDetails(FilterQueryDto filterQueryDto)
        {
            
            return new SuccessDataResult<List<FilterQueryDto>>
             (_identityDal.GetFilterQueryDetails(p => p.PersonelKimlikId != filterQueryDto.PersonelKimlikId &

               (filterQueryDto.IsYeriId != 0 ? (p.IsYeriId == filterQueryDto.IsYeriId) : (p.IsYeriId != filterQueryDto.IsYeriId)) &
               (filterQueryDto.UcretTurId != 0 ? (p.UcretTurId == filterQueryDto.UcretTurId) : (p.UcretTurId != filterQueryDto.UcretTurId)) &
               (filterQueryDto.GenelMudurlukId != 0 ? (p.GenelMudurlukId == filterQueryDto.GenelMudurlukId) : (p.GenelMudurlukId != filterQueryDto.GenelMudurlukId)) &
               (filterQueryDto.MeslekKolId != 0 ? (p.MeslekKolId == filterQueryDto.MeslekKolId) : (p.MeslekKolId != filterQueryDto.MeslekKolId)) &
             //(filterQueryDto.IdarecilikId != 0 ? (p.IdarecilikId == filterQueryDto.IdarecilikId) : (p.IdarecilikId != filterQueryDto.IdarecilikId))&
               (filterQueryDto.GunlukCalismaSureId != 0 ? (p.GunlukCalismaSureId == filterQueryDto.GunlukCalismaSureId) : (p.GunlukCalismaSureId != filterQueryDto.GunlukCalismaSureId)) &
               (filterQueryDto.EngelDurumId != 0 ? (p.EngelDurumId == filterQueryDto.EngelDurumId) : (p.EngelDurumId != filterQueryDto.EngelDurumId)) &
               (filterQueryDto.MedeniHalId != 0 ? (p.MedeniHalId == filterQueryDto.MedeniHalId) : (p.MedeniHalId != filterQueryDto.MedeniHalId)) &
               (filterQueryDto.CinsiyetId != 0 ? (p.CinsiyetId == filterQueryDto.CinsiyetId) : (p.CinsiyetId != filterQueryDto.CinsiyetId)) &
               (filterQueryDto.IstihtamDurumId != 0 ? (p.IstihtamDurumId == filterQueryDto.IstihtamDurumId) : (p.IstihtamDurumId != filterQueryDto.IstihtamDurumId)) &
               (filterQueryDto.KatilisTarihi1 != null ? (p.KatilisTarihi.Value >= filterQueryDto.KatilisTarihi1 && p.KatilisTarihi.Value <= filterQueryDto.KatilisTarihi2) : (p.KatilisTarihi != filterQueryDto.KatilisTarihi))&
               (filterQueryDto.DogumTarihiBaslangic != null ? (p.DogumTarihi.Value >= filterQueryDto.DogumTarihiBaslangic && p.DogumTarihi.Value <= filterQueryDto.DogumTarihiBitis) : (p.DogumTarihi != filterQueryDto.DogumTarihi))
             
               ));
        }
        

    }
}
//                                                     