using System;

namespace ExpenseTracker.Data.Entities
{
    public class Budget : Entity
    {
        public decimal Ammount { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
