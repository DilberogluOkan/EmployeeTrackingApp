using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        IResult Add(Course course);
        IResult Delete(Course course);
        IResult Update(Course course);
        IDataResult<List<Course>> GetAll();
        IDataResult<Course> GetById(int courseId);
        IDataResult<List<Course>> GetAllByIdentityId(int id);
    }
}
