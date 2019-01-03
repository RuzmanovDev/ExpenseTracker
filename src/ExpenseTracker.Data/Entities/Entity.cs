using System;

namespace ExpenseTracker.Data.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            this.DateCreated = DateTime.UtcNow;
        }

        public virtual Guid Id { get; set; }

        public virtual DateTime DateCreated { get; private set; }
    }
}
