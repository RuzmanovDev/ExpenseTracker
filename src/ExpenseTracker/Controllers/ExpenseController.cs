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
        private readonly ExpenseTrackerDbContext context = new ExpenseTrackerDbContext();
        private static ExpenseListViewModel expenseList = new ExpenseListViewModel();

        public ExpenseController()
        {

        }

        [HttpGet]
        public IActionResult ExpenseList()
        {
            return View(expenseList);
        }

        [HttpGet]
        public IActionResult PostExpense()
        {
            return View(new PostExpenseViewModel());
        }

        [HttpPost]
        public IActionResult PostExpense(PostExpenseViewModel expenseData)
        {
            var expense = new ExpenseViewModel();
            expense.Title = expenseData.Name;
            expense.Description = expenseData.ExpenseDescription;
            expense.Ammount = expenseData.Ammount;
            expense.DateOfPayment = expenseData.DateOfPayment;

            var tags = expenseData.Tags.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => new TagViewModel() { Name = t }).ToList();

            expense.Tags = tags;
            expenseList.Expenses.Add(expense);

            return PostExpense();
        }
    }
}