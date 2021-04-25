using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMilitaryStatusService:IServiceRepository<MilitaryStatus>
    {
        IDataResult<List<MilitaryStatus>> GetAll();
        IDataResult<MilitaryStatus>Get(int militaryStatusId);

    }
}
