﻿using EFCTesting.DataModels;
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
            entity.Tests = _context.Tests.ToList();
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
                .Include(u => u.Tests)
                .ThenInclude(u => u.Questions)
                .ThenInclude(u => u.Answer)
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
    }
}
