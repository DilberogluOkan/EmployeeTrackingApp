using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGraduationService
    {
        IResult Add(Graduation graduation);
        IResult Delete(Graduation graduation);
        IResult Update(Graduation graduation);
        IDataResult<List<Graduation>> GetAll();
        IDataResult<Graduation> GetById(int graduationId);
        IDataResult<List<Graduation>> GetAllByIdentityId(int id);
        IDataResult<List<GraduationDto>> GetGraduationDetails(int id);
        IDataResult<List<GraduationDto>> GetByGraduationIdDetails(int id);
    }
}

