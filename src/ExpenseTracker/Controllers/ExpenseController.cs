using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpenseTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        private static ExpenseListViewModel expenseList = new ExpenseListViewModel();

        public ExpenseController()
        {

        }

        public IActionResult Index()
        {
            return View(expenseList);
        }

        [HttpPost]
        public IActionResult Index(string expenseName)
        {
            expenseList.Expenses.Add(expenseName);

            return View(expenseList);
        }
    }
}