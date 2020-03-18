using System.Collections.Generic;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository<TransferLog>
    {
        private TransferDbContext _ctx;

        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
            _ctx.Database.EnsureCreated();
        }

        public IEnumerable<TransferLog> GetTransfersLog()
        {
            return _ctx.Transfers;
        }
    }
}
