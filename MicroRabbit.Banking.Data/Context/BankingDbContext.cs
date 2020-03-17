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
                    .HasNoKey();

            modelBuilder.Entity<Account>()
                         .HasData( new Account() { AccountType = "Checking", AccountBalance = 0 },
                                   new Account() { AccountType = "Savings", AccountBalance = 0 });

        }

        public DbSet<Account> Accounts { get; set; }
    }
}
