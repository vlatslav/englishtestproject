using EFCTesting.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.Repository
{
    public class AnswerRepository : IAnswerRepository
    {
        private EnglishContext _context;
        public AnswerRepository(EnglishContext context)
        {
            _context = context;
        }

        public async Task Add(Answer entity)
        {
            await _context.Answers.AddAsync(entity);
        }

        public void Delete(Answer entity)
        {
            _context.Answers.Remove(entity);
        }

        public async Task<IEnumerable<Answer>> GetAll()
        {
            return await _context.Answers.ToListAsync();
        }


        public async Task<Answer> GetByid(int id)
        {
            return await _context.Answers.FirstOrDefaultAsync(u => u.AnswerID == id);
        }

        public void Update(Answer question)
        {
            var answer = _context.Answers.FirstOrDefault(u => u.AnswerID == question.AnswerID);
            answer.Correct = question.Correct;
            answer.Answ = question.Answ;
        }
    }
}
