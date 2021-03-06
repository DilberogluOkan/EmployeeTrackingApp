﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PromotionManager : IPromotionService
    {
        IPromotionDal _promotionDal;

        public PromotionManager(IPromotionDal promotionDal)
        {
            _promotionDal = promotionDal;
        }

        public IResult Add(Promotion promotion)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Promotion promotion)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Promotion> Get(int promotionId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Promotion>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Promotion>> GetAllByIdentityId(int id)
        {
            return new SuccessDataResult<List<Promotion>>(_promotionDal.GetAll(p => p.PersonelKimlikId == id));
        }

        public IDataResult<Promotion> GetById(int promotionId)
        {
            return new SuccessDataResult<Promotion>(_promotionDal.Get(p => p.PersonelTerfiId == promotionId));
        }

        public IDataResult<List<PromotionDto>> GetPromotionDetails(int id)
        {
            return new SuccessDataResult<List<PromotionDto>>(_promotionDal.GetPromotionDetails(p => p.PersonelKimlikId == id));
        }

        public IResult Update(Promotion promotion)
        {
            _promotionDal.Update(promotion);
            return new SuccessResult();
           
        }
    }
}
