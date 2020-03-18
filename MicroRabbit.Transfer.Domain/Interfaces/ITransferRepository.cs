using System.Collections.Generic;
using MicroRabbit.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    public interface ITransferRepository<T> : IRepository<T> where T : IAggregateRoot
    {
        IEnumerable<TransferLog> GetTransfersLog();

        void Add(TransferLog transferLog);
    }
}
