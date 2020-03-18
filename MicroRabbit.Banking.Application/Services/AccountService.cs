using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository<Account> _accountRepository;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository<Account> accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }

        public IEnumerable<Account> GetAllAcounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            //Passa o DTO da camada de aplicação para um comando 
            var createTransferCommand = new CreateTransferCommand(
                    accountTransfer.FromAccount,
                    accountTransfer.ToAccount,
                    accountTransfer.TransferAccount);

            //Envia um comando
            _bus.SendCommand(createTransferCommand);
        }
    }
}
