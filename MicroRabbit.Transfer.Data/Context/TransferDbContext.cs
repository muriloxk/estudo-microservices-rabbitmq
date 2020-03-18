using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransferLog>().HasKey(x => x.Id);

            modelBuilder.Entity<TransferLog>()
                        .HasData(new TransferLog() { Id = 1, FromAccount = 1, ToAccount = 2, TransferAmount = 5.1m },
                                 new TransferLog() { Id = 2, FromAccount = 2, ToAccount = 1, TransferAmount = 15.2m });
        }

        public DbSet<TransferLog> Transfers { get; set; }
    }
}
