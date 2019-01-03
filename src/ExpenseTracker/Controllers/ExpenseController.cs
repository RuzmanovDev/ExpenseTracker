using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpenseTracker.Data;
using ExpenseTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ExpenseTrackerDbContext context;
        private static ExpenseListViewModel expenseList = new ExpenseListViewModel();

        public ExpenseController(ExpenseTrackerDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult ExpenseList(int page = 1)
        {
            page = page - 1;
            if (page < 0)
            {
                page = 0;
            }

            var pagedExpenseList = expenseList.Expenses.Skip(page * 10).Take(10).ToList();
            var expenseList1 = new ExpenseListViewModel();
            expenseList1.TotalCount = expenseList.Expenses.Count;
            expenseList1.Expenses = pagedExpenseList;

            return View(expenseList1);
        }

        [HttpGet]
        public IActionResult PostExpense()
        {
            return View(new PostExpenseViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PostExpense(PostExpenseViewModel expenseData)
        {
            for (int i = 0; i < 100; i++)
            {
                var expense = new ExpenseViewModel();
                expense.Title = expenseData.Name + i.ToString();
                expense.Description = expenseData.ExpenseDescription;
                expense.Ammount = expenseData.Ammount;
                expense.DateOfPayment = expenseData.DateOfPayment;

                var tags = expenseData.Tags.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => new TagViewModel() { Name = t }).ToList();

                expense.Tags = tags;
                expenseList.Expenses.Add(expense);
            }

            return this.RedirectToAction(nameof(ExpenseController.PostExpense));
        }
    }
}