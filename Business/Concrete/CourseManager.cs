using Business.Abstract;
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
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IResult Add(Course course)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Course course)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Course> GetById(int courseId)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(p => p.KursBilgiId == courseId));
        }

        public IDataResult<List<Course>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Course>> GetAllByIdentityId(int id)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p => p.KursBilgiId == id));
        }

        public IResult Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
