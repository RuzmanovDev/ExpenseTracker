using System;
using System.Collections.Generic;
using ExpenseTracker.Data;
using ExpenseTracker.Data.Entities;
using ExpenseTracker.Dto;

namespace ExpenseTracker.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly ExpenseTrackerDbContext dbContext;

        public ExpenseService(ExpenseTrackerDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException("dbcontext");
        }

        public void Create(ExpenseDto expenseData)
        {
            var expense = new Expense()
            {
                Title = expenseData.Title,
                Description = expenseData.Description,
                DateOfPayment = expenseData.DateOfPayment,
                UserId = expenseData.UserId,
                ExpenseAmmount = expenseData.ExpenseAmmount
            };


            dbContext.Expenses.Add(expense);
        }

        public IEnumerable<ExpenseDto> GetExpenses()
        {
            // add logic for getting expenses, consider paging
            return new List<ExpenseDto>();
        }
    }
}
