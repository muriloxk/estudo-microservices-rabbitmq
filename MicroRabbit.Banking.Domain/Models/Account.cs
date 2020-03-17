using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Entities;

namespace MicroRabbit.Banking.Domain.Models
{
    public class Account : Entity, IAggregateRoot
    {
        public string AccountType { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
