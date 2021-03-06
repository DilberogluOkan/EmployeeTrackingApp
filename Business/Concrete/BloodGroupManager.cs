﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BloodGroupManager : IBloodGroupService
    {
        IBloodGroupDal _bloodGroupDal;

        public BloodGroupManager(IBloodGroupDal bloodGroupDal)
        {
            _bloodGroupDal = bloodGroupDal;
        }

        public IDataResult<List<BloodGroup>> GetAll()
        {
            return new SuccessDataResult<List<BloodGroup>>(_bloodGroupDal.GetAll());
        }
    }
}
