using System;

namespace ExpenseTracker.Data.Entities
{
    public class ExpensesTags
    {
        public Guid ExpenseId { get; set; }

        public Guid TagId { get; set; }

        public virtual Expense Expense { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
