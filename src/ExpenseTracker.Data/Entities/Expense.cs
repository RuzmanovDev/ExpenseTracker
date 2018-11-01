using System;
using System.Collections.Generic;

namespace ExpenseTracker.Data.Entities
{
    public class Expense : Entity
    {
        private ICollection<ExpensesTags> expensesTags;

        public Expense()
        {
            this.expensesTags = new HashSet<ExpensesTags>();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal ExpenseAmmount { get; set; }

        public DateTime DateOfPayment { get; set; }

        public virtual ICollection<ExpensesTags> ExpensesTags
        {
            get { return this.expensesTags; }
            set { this.expensesTags = value; }
        }

        public string UserId { get; set; }

        public virtual User User  { get; set; }
    }
}
