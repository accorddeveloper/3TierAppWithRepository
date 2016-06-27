namespace _3TierAppWithRepository.DAL.Interfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
