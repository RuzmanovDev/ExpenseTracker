using System;
using System.Collections.Generic;
using System.Security.Claims;
using ExpenseTracker.Dto;
using ExpenseTracker.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.WebApi.Controllers.Expense
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseService expenseService;

        public ExpenseController(IExpenseService expenseService)
        {
            this.expenseService = expenseService ?? throw new ArgumentNullException(nameof(expenseService));
        }

        [HttpPost]
        public void Create(ExpenseDto expenseData)
        {
            var userIdClaim = this.User.FindFirst(ClaimTypes.NameIdentifier);
            expenseData.UserId = userIdClaim.Value;
            this.expenseService.Create(expenseData);
        }

        [HttpGet]
        public IEnumerable<ExpenseDto> Get()
        {
            var result = this.expenseService.GetExpenses();

            return result;
        }
    }
}
