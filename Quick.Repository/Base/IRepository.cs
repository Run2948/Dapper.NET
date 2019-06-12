using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Quick.Repository.Base
{
    interface IRepository<T>
    {
        List<T> GetList();

        T Get(object id);

        bool Update(T t);

        T Insert(T apply);

        bool Delete(T t);
    }
}
