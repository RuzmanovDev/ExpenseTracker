using ExpenseTracker.Dto;
using System.Collections.Generic;

namespace ExpenseTracker.Services
{
    public interface IExpenseService
    {
        void Create(ExpenseDto expenseData);

        IEnumerable<ExpenseDto> GetExpenses();
    }
}