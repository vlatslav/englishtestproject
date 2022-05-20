using EFCTesting.DataModels;
using EFCTesting.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private EnglishContext _context;
        public IAnswerRepository answerRepository;
        public IQuestionRepository questionRepository;
        public UnitOfWork(EnglishContext context)
        {
            _context = context;
        }
        public IAnswerRepository AnswerRepository
        {
            get
            {
                if(answerRepository is null)
                {
                    answerRepository = new AnswerRepository(_context);
                }
                return answerRepository;
            }
        }

        public IQuestionRepository QuestionRepository
        {
            get
            {
                if (questionRepository is null)
                {
                    questionRepository = new QuestionRepository(_context);
                }
                return questionRepository;
            }
        }

        public async Task Update()
        {
            await _context.SaveChangesAsync();
        }
    }
}
