using EFCTesting.DataModels;
using EFCTesting.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        void DeleteById(int id);
        void SaveChanges();
        Task<IEnumerable<User>> GetAllWithDetails();
    }
}
