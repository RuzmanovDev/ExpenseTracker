using System.Collections.Generic;

namespace ExpenseTracker.Models
{
    public class ExpenseListViewModel
    {
        public ExpenseListViewModel()
        {
            this.Expenses = new List<string>();
        }

        public ICollection<string> Expenses { get; set; }
    }
}
