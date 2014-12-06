namespace ShiftSchedule.Domain.Entities.Base
{
    /// <summary>
    /// Base class for all Entity types.
    /// </summary>
    public abstract class BaseEntity
    {

    }
    public class Entity<TPrimaryKey> : BaseEntity,IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        public virtual TPrimaryKey Id { get; set; }
    }
}