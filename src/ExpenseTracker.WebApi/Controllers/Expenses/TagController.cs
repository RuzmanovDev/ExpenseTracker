using System;
using ExpenseTracker.Services;
using ExpenseTracker.WebApi.DtoModels;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.WebApi.Controllers.Expense
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagService tagService;

        public TagController(ITagService tagService)
        {
            this.tagService = tagService ?? throw new ArgumentNullException(nameof(tagService));
        }

        [HttpPost]
        public TagDto Tag(TagDto tagModel)
        {
            return this.tagService.CreateTag(tagModel);
        }
    }
}
