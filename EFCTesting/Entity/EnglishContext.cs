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
        public DbSet<TestUser> TestUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EFDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestUser>()
                .HasKey(t => new { t.TestId, t.UserId });

            modelBuilder.Entity<TestUser>()
                .HasOne(pt => pt.User)
                .WithMany(p => p.Tests)
                .HasForeignKey(pt => pt.UserId);
                
            modelBuilder.Entity<TestUser>()
                .HasOne(pt => pt.Test)
                .WithMany(t => t.Users)
                .HasForeignKey(pt => pt.TestId);
        }

    }
}
