using Core.DataAccess;
using Entities.Concrete.DynamicDataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMilitaryStatusDal:IEntityRepository<MilitaryStatus>
    {
    }
}
