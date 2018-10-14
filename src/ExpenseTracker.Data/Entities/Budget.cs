using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Data.Entities
{
    public class Budget : Entity
    {
        public decimal Ammount { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}
