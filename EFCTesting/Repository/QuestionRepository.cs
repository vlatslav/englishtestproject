using EFCTesting.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private EnglishContext _context;
        public QuestionRepository(EnglishContext context)
        {
            _context = context;
        }
        public async Task Add(Question entity)
        {
            await _context.Question.AddAsync(entity);
        }

        public void Delete(Question entity)
        {
            _context.Question.Remove(entity);
        }

        public async Task<IEnumerable<Question>> GetAll()
        {
            return await _context.Question.ToListAsync();
        }

        public async Task<IEnumerable<Question>> GetAllWithDetails()
        {
            return await _context.Question
                .Include(u => u.Answer)
                .ToArrayAsync();
        }

        public async Task<Question> GetByid(int id)
        {
            return await _context.Question.FirstOrDefaultAsync(u => u.QuestionID == id);
        }

        public void Update(Question question)
        {
            _context.Entry(question).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
