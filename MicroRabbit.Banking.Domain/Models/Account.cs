using MicroRabbit.Domain.Core.Entities;
using MicroRabbit.Domain.Interfaces;

namespace MicroRabbit.Banking.Domain.Models
{
    public class Account : Entity, IAggregateRoot
    {
        public string AccountType { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
