using EFCTesting.DataModels;
using EFCTesting.Interfaces;
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
        public IUserRepository userRepository;
        public ITestRepository testRepository;
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
        public IUserRepository UserRepository
        {
            get
            {
                if (userRepository is null)
                {
                    userRepository = new UserRepository(_context);
                }
                return userRepository;
            }
        }
        public ITestRepository TestRepository
        {
            get
            {
                if (testRepository is null)
                {
                    testRepository = new TestRepository(_context);
                }
                return testRepository;
            }
        }

        public async Task Update()
        {
            await _context.SaveChangesAsync();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
