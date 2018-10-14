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

        public string Name { get; set; }

        public decimal ExpenseAmmount { get; set; }

        public DateTime DateOfPayment { get; set; }

        public virtual ICollection<ExpensesTags> ExpensesTags
        {
            get { return this.expensesTags; }
            set { this.expensesTags = value; }
        }
    }
}
