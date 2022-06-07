using EFCTesting.DataModels;
using EFCTesting.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.Interfaces
{
    public interface ITestUserRepository : IRepository<TestUser> 
    {

    }
}
