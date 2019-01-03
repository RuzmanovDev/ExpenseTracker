using ExpenseTracker.Data;
using ExpenseTracker.Data.Entities;
using ExpenseTracker.WebApi.DtoModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTracker.WebApi.Controllers.Expense
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ExpenseTrackerDbContext context;
        public TagController(ExpenseTrackerDbContext dbContext)
        {
            this.context = dbContext;
        }

        // GET api/values
        [HttpPost]
        public ActionResult<Tag> Tag(TagDto tagModel)
        {
            var tag = new Tag()
            {
                Name = tagModel.Name
            };
            if (context.Tags.Any(x => x.Name == tagModel.Name))
            {
                throw new Exception("Ima takav tag pedal");
            }

            context.Tags.Add(tag);
            context.SaveChanges();

            return tag;
        }
    }
}
