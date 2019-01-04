using ExpenseTracker.WebApi.DtoModels;

namespace ExpenseTracker.Services
{
    public interface ITagService
    {
        TagDto CreateTag(TagDto tagDto);
    }
}
