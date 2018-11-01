using System.Collections.Generic;

namespace ExpenseTracker.Models
{
    public class ExpenseListViewModel
    {
        public ExpenseListViewModel()
        {
            this.Expenses = new List<ExpenseViewModel>();
        }

        public ICollection<ExpenseViewModel> Expenses { get; set; }
    }
}
