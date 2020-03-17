namespace MicroRabbit.Banking.Domain.Interfaces
{
    public interface IRepository<T> where T : IAggregateRoot
    {
    }
}
