using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Data.Entities
{
    public class User : IdentityUser
    {
        private ICollection<Budget> budgets;
        private ICollection<Savings> savings;
        private ICollection<Expense> expenses;

        public User()
        {
            this.budgets = new HashSet<Budget>();
            this.savings = new HashSet<Savings>();
            this.expenses = new HashSet<Expense>();
        }

        public virtual ICollection<Budget> Budgets
        {
            get { return this.budgets; }
            set { this.budgets = value; }
        }

        public virtual ICollection<Savings> Savings
        {
            get { return this.savings; }
            set { this.savings = value; }
        }

        public virtual ICollection<Expense> Expenses
        {
            get { return this.expenses; }
            set { this.expenses = value; }
        }
    }
}
