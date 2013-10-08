using System.Linq;

namespace DataAccessLayer
{
    internal interface IRepository<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
        T GetById(int id);
    }
}
