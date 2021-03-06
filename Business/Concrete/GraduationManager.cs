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
    public class GraduationManager : IGraduationService
    {
        IGraduationDal _graduationDal;

        public GraduationManager(IGraduationDal graduationDal)
        {
            _graduationDal = graduationDal;
        }

        public IResult Add(Graduation graduation)
        {

            _graduationDal.Add(graduation);
            return new SuccessResult();
        }

        public IResult Delete(Graduation graduation)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Graduation> GetById(int graduationId)
        {
            return new SuccessDataResult<Graduation>(_graduationDal.Get(p => p.PersonelEgitimId == graduationId));

        }

        public IDataResult<List<Graduation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Graduation>> GetAllByIdentityId(int id)
        {
            return new SuccessDataResult<List<Graduation>>(_graduationDal.GetAll(p => p.PersonelKimlikId == id));

        }

        public IResult Update(Graduation graduation)
        {
            _graduationDal.Update(graduation);
            return new SuccessResult();
        }

        public IDataResult<List<GraduationDto>> GetGraduationDetails(int id)
        {
            return new SuccessDataResult<List<GraduationDto>>(_graduationDal.GetGraduationDetails(p => p.PersonelKimlikId == id));
        }

        public IDataResult<List<GraduationDto>> GetByGraduationIdDetails(int id)
        {
            return new SuccessDataResult<List<GraduationDto>>(_graduationDal.GetGraduationDetails(p => p.EgitimDurumId == id));

        }
    }
}
