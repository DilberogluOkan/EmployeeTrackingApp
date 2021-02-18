﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PermissionManager : IPermissionService
    {
        IPermissionDal _permissionDal;

        public PermissionManager(IPermissionDal permissionDal)
        {
            _permissionDal = permissionDal;
        }

        public IResult Add(Permission permission)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Permission permission)
        {
            throw new NotImplementedException();
        }

        
        public IDataResult<List<Permission>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Permission>> GetAllByIdentityId(int id)
        {
            return new SuccessDataResult<List<Permission>>(_permissionDal.GetAll(p => p.IzinBilgisiId == id));
        }

        public IDataResult<Permission> GetById(int permissionId)
        {
            return new SuccessDataResult<Permission>(_permissionDal.Get(p => p.IzinBilgisiId == permissionId));
        }

        public IResult Update(Permission permission)
        {
            throw new NotImplementedException();
        }
    }
}
