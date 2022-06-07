﻿using System;
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

                var user = new User()
                {
                    NickName = "Vova"
                };
                await uow.UserRepository.Add(user);
                await uow.Update();
            }
        }
    }
}
