using EFCTesting.DataModels;
using EFCTesting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.Repository
{
    public class TestUserRepository : ITestUserRepository
    {
        private readonly EnglishContext _context;
        public TestUserRepository(EnglishContext context)
        {
            _context = context;
        }
        public Task Add(TestUser entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TestUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TestUser>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TestUser> GetByid(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TestUser question)
        {
            var result = _context.TestUser.FirstOrDefault(x => x.UserId == question.UserId && x.TestId == question.TestId);
            result.Progress = question.Progress;
            result.Done = question.Done;
            _context.SaveChanges();
        }
    }
}
