using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCTesting.Configuration;
using EFCTesting.DataModels;
using EFCTesting.UOW;
using Microsoft.EntityFrameworkCore;

namespace EFCTesting
{
    class Program
    {
        static async Task Main(string[] args)
        {
            new DataInitializer();
            using (EnglishContext context = new EnglishContext())
            {
                //context
                UnitOfWork uow = new UnitOfWork(context);
                var user = (await uow.UserRepository.GetAllWithDetails()).FirstOrDefault(x => x.UserID == 1);

                var test = user.Tests.Where(x => x.UserId == user.UserID).Select(x => x.Test).ElementAt(1);
                test.Progress = 12;
                test.Done = true;

                uow.TestRepository.Update(test);
                uow.UserRepository.Update(user);
                await uow.Update();

                var user_test = (await uow.UserRepository.GetAllWithDetails()).FirstOrDefault(x => x.UserID == 2);
                var test2 = user_test.Tests.Where(x => x.UserId == user.UserID).Select(x => x.Test);
            }
        }
    }
}
