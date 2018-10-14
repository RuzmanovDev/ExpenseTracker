using System.Collections.Generic;

namespace ExpenseTracker.Data.Entities
{
    public class Tag : Entity
    {
        private ICollection<ExpensesTags> expensesTags;

        public Tag()
        {
            this.expensesTags = new HashSet<ExpensesTags>();
        }

        public string Name { get; set; }

        public virtual ICollection<ExpensesTags> ExpensesTags
        {
            get { return this.expensesTags; }
            set { this.expensesTags = value; }
        }
    }
}
