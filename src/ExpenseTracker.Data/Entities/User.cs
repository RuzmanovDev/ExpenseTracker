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

        public User()
        {
            this.Budgets = new HashSet<Budget>();
            this.savings = new HashSet<Savings>();
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
    }
}
