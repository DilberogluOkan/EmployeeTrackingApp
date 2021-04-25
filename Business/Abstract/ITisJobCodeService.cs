﻿using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITisJobCodeService:IServiceRepository<TisJobCode>
    {
        IDataResult<TisJobCode> GetById(string tisJobCodeId);
        IDataResult<List<TisJobCode>> GetAll();
    }
}
