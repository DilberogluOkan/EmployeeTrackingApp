﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITemporaryDutyService
    {
        IResult Add(TemporaryDuty temporaryDuty);
        IResult Delete(TemporaryDuty temporaryDuty);
        IResult Update(TemporaryDuty temporaryDuty);
        IDataResult<List<TemporaryDuty>> GetAll();
        IDataResult<TemporaryDuty> GetById(int temporaryDutyId);
        IDataResult<List<TemporaryDuty>> GetAllByIdentityId(int id);
        IDataResult<List<TemporaryDutyDto>> GetAllTemporaryDutyDetails(int id);
        IDataResult<List<TemporaryDutyDto>> GetTemporaryDutyDetails(int id);
    }
}
