using _3TierAppWithRepository.DAL.Interfaces;

namespace _3TierAppWithRepository.DAL.Abstracts
{
    public abstract class BaseEntity { }
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        public virtual T Id { get; set; }

    }
}
