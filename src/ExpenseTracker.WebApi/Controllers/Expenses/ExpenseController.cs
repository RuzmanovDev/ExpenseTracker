using ExpenseTracker.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.WebApi.Controllers.Expense
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly ExpenseTrackerDbContext context;
        public ExpenseController(ExpenseTrackerDbContext dbContext)
        {
            this.context = dbContext;
        }

        // GET api/values
        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<string>> Get()
        {
            var tagNames = context.Tags.Select(x => x.Name).ToArray();
            return tagNames;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Unrestricted()
        {
            var tagNames = context.Tags.Select(x => x.Name).ToArray();
            return tagNames;
        }
    }
}
