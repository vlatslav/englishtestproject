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
    public class UserRepository : IUserRepository
    {
        private EnglishContext _context;
        public UserRepository(EnglishContext context)
        {
            _context = context;
        }

        public async Task Add(User entity)
        {
            var alltests = _context.Tests.ToList();
            foreach (var item in alltests)
            {
                var testmod = new TestUser();
                testmod.User = entity;
                testmod.Test = item;
                entity.Tests.Add(testmod);
                
            }
            await _context.Users.AddAsync(entity);
        }

        public void Delete(User entity)
        {
            _context.Users.Remove(entity);
        }
        public void DeleteById(int id)
        {
            var user = _context.Users.First(u => u.UserID == id);
            _context.Users.Remove(user);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToArrayAsync();
        }

        public async Task<IEnumerable<User>> GetAllWithDetails()
        {
            return await _context.Users
                .Include(x => x.Tests)
                .ThenInclude(x => x.Test)
                .ThenInclude(x => x.Questions)
                .ToArrayAsync(); 
        }

        public async Task<User> GetByid(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserID == id);
        }

        public void Update(User question)
        {
            var result = _context.Users.FirstOrDefault(u => u.UserID == question.UserID);
            result.NickName = question.NickName;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
