using System.Collections.Generic;
using System.Linq;
using ExpenseTracker.Data.Entities;
using ExpenseTracker.Data.Repositories;
using ExpenseTracker.Dto;

namespace ExpenseTracker.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IETData<Expense> expenseRepo;

        public ExpenseService(IETData<Expense> expenseRepo)
        {
            this.expenseRepo = expenseRepo;
        }

        public void Create(ExpenseDto expenseData)
        {
            var expense = new Expense()
            {
                Title = expenseData.Title,
                Description = expenseData.Description,
                DateOfPayment = expenseData.DateOfPayment,
                UserId = expenseData.UserId,
                ExpenseAmount = expenseData.ExpenseAmount
            };

            this.expenseRepo.Add(expense);
            this.expenseRepo.SaveChanges();
        }

        public IEnumerable<ExpenseDto> GetExpenses()
        {
            // add logic for getting expenses, consider paging
            return this.expenseRepo.Get().Select(x => new ExpenseDto()
            {
                DateOfPayment = x.DateOfPayment,
                Description = x.Description,
                Title = x.Title,
                ExpenseAmount = x.ExpenseAmount,
                UserId = x.UserId
            });
        }
    }
}
