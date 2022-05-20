using EFCTesting.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.UOW
{
    public interface IUnitOfWork
    {
        public IAnswerRepository AnswerRepository { get; }
        public IQuestionRepository QuestionRepository { get; }

        Task Update();
    }
}
