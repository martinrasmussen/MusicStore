using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    internal interface IRepository<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
