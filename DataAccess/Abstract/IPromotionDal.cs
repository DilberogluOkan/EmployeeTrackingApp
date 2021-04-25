﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IPromotionDal:IEntityRepository<Promotion>
    {
        List<PromotionDto> GetPromotionDetails(Expression<Func<Promotion, bool>> filter = null);
    }
}
