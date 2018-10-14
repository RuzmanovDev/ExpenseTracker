using ExpenseTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Data.FluentMappings
{
    public class SavingsFluentMapping : IEntityTypeConfiguration<Savings>
    {
        public void Configure(EntityTypeBuilder<Savings> savings)
        {
            savings.HasKey(s => s.Id);
        }
    }
}
