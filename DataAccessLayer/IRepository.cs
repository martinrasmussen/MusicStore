using System.Linq;

namespace DataAccessLayer
{
    internal interface IRepository<IEntity>
    {
        void Insert(IEntity entity);
        void Delete(IEntity entity);
        IQueryable<IEntity> GetAll();
        IEntity GetById(int id);
    }
}
