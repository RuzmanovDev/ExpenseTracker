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

        public ExpenseController()
        {

        }

        [HttpGet]
        public IActionResult PostExpense()
        {
            return View(new PostExpenseViewModel());
        }

        [HttpPost]
        public IActionResult PostExpense(PostExpenseViewModel expenseViewModel)
        {
            return PostExpense();
        }
    }
}