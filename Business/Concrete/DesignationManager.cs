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
    public class DesignationManager : IDesignationService
    {
        IDesignationDal _designationDal;

        public DesignationManager(IDesignationDal designationDal)
        {
            _designationDal = designationDal;
        }

        public IResult Add(Designation designation)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Designation designation)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Designation> Get(int designationId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Designation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Designation designation)
        {
            throw new NotImplementedException();
        }
    }
}