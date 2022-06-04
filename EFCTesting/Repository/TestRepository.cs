using EFCTesting.DataModels;
using EFCTesting.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.Repository
{
    public class TestRepository : ITestRepository
    {
        private EnglishContext _context;
        public TestRepository(EnglishContext context)
        {
            _context = context;
        }

        public async Task Add(Test entity)
        {
            await _context.Tests.AddAsync(entity);
        }

        public void Delete(Test entity)
        {
            _context.Tests.Remove(entity);
        }

        public async Task<IEnumerable<Test>> GetAll()
        {
            return await _context.Tests.ToArrayAsync();
        }

        public async Task<IEnumerable<Test>> GetAllWithDetails()
        {
            return await _context.Tests.Include(u => u.Questions).ThenInclude(u => u.Answer).ToArrayAsync();
        }

        public async Task<Test> GetByid(int id)
        {
            return await _context.Tests.FirstOrDefaultAsync(u => u.TestID == id);
        }

        public void Update(Test question)
        {
            var result = _context.Tests.FirstOrDefault(u => u.TestID == question.TestID);
            result.Progress = question.Progress;
            result.Done = question.Done;
            result.Questions = question.Questions;
            result.Users = question.Users;
        }
    }
}
