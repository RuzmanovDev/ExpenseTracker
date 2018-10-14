using ExpenseTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Data.FluentMappings
{
    public class ExpensesTagsFluentMapping : IEntityTypeConfiguration<ExpensesTags>
    {
        public void Configure(EntityTypeBuilder<ExpensesTags> builder)
        {
            builder.HasKey(et => new { et.ExpenseId, et.TagId });
            builder.HasOne(e => e.Expense).WithMany(e => e.ExpensesTags).HasForeignKey(e => e.ExpenseId);
            builder.HasOne(t => t.Tag).WithMany(t => t.ExpensesTags).HasForeignKey(t => t.TagId);
        }
    }
}
