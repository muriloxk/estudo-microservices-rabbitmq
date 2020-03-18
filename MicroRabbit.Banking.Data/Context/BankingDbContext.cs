using System;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                        .HasData(new Account() { Id = 1, AccountType = "Checking", AccountBalance = 100 },
                                 new Account() { Id = 2, AccountType = "Savings",  AccountBalance = 100 });
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
