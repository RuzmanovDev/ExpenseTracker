using System;

namespace ExpenseTracker.Data.Entities
{
    public abstract class Entity
    {
        public virtual Guid Id { get; set; }

        public virtual DateTime DateCreated { get; set; }
    }
}
