using System.Collections.Generic;
using System.Threading.Tasks;

namespace simple_office.Domain.Interfaces.Repositories
{
    public interface ICrudRepository<T> where T : class
    {
        void Create(T obj);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        void Update(T obj);
        void Delete(T obj);
        void Dispose();
    }
}
