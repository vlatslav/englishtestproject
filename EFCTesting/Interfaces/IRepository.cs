using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.Repository
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> GetByid(int id);
        Task<IEnumerable<TEntity>> GetAll();
        void Update(TEntity question);
        Task Add(TEntity entity);
        void Delete(TEntity entity); 
    }
}
