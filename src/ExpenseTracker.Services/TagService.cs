using System;
using System.Collections.Generic;
using System.Text;
using ExpenseTracker.Data.Entities;
using ExpenseTracker.Data.Repositories;
using ExpenseTracker.WebApi.DtoModels;

namespace ExpenseTracker.Services
{
    public class TagService : ITagService
    {
        private readonly IETData<Tag> tagRepo;

        public TagService(IETData<Tag> tagRepo)
        {
            this.tagRepo = tagRepo ?? throw new ArgumentNullException(nameof(tagRepo));
        }

        public TagDto CreateTag(TagDto tagDto)
        {
            var tagToBeCreated = new Tag()
            {
                Name = tagDto.Name,
            };

            this.tagRepo.Add(tagToBeCreated);
            this.tagRepo.SaveChanges();

            return tagDto;
        }
    }
}
