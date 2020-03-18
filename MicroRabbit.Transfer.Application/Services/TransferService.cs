using System.Collections.Generic;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository<TransferLog> _transferRepository;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository<TransferLog> transferRepository, IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTransfersLog()
        {
            return _transferRepository.GetTransfersLog();
        }
    }
}
