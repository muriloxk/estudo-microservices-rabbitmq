namespace MicroRabbit.Domain.Interfaces
{
    public interface IRepository<T> where T : IAggregateRoot
    {
    }
}
