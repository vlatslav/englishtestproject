using EFCTesting.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.DataModels
{
    public class EnglishContext : DbContext
    {
        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=HUNTAH;Database=EFDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
