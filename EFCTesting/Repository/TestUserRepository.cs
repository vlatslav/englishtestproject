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
    public class TestUserRepository : ITestUserRepository
    {
        private readonly EnglishContext _context;
        public TestUserRepository(EnglishContext context)
        {
            _context = context;
        }
        public async Task Add(TestUser entity)
        {
            await _context.TestUser.AddAsync(entity);
        }

        public void Delete(TestUser entity)
        {
            _context.TestUser.Remove(entity);
        }

        public async Task<IEnumerable<TestUser>> GetAll()
        {
            return await _context.TestUser.ToArrayAsync();
        }

        public Task<TestUser> GetByid(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TestUser question)
        {
            _context.Entry(question).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
