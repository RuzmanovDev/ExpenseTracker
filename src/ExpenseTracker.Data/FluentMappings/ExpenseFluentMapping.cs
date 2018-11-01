using ExpenseTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Data.FluentMappings
{
    public class ExpenseFluentMapping : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> expenses)
        {
            expenses.HasKey(x => x.Id);
            expenses.HasOne(x => x.User).WithMany(x => x.Expenses).HasForeignKey(x => x.UserId);
        }
    }
}
