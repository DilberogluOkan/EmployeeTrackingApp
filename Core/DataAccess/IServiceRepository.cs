using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IServiceRepository<T>
    {
        IResult Add(T entity);
        IResult Delete(T entity);
        IResult Update(T entity);
    }
}
