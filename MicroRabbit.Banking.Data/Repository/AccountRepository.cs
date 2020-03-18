using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository<Account>
    {

        private readonly BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
            //EF Core seed memory;
            _ctx.Database.EnsureCreated();
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
