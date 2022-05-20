using EFCTesting.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.Repository
{
    public interface IQuestionRepository : IRepository<Question>
    {
        Task<IEnumerable<Question>> GetAllWithDetails();
    }
}
