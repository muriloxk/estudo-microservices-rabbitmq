using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository<Account> _accountRepository;

        public AccountService(IAccountRepository<Account> accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAllAcounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}
