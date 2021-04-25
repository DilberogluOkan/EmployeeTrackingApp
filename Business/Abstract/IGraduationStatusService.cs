using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGraduationStatusService
    {
        IDataResult<List<GraduationStatus>> GetAll();
    }
}
