using ExpenseTracker.Data.Entities;
using ExpenseTracker.Data.FluentMappings;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data
{
    public class ExpenseTrackerDbContext : IdentityDbContext
    {
        public ExpenseTrackerDbContext(DbContextOptions<ExpenseTrackerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ExpenseFluentMapping());
            modelBuilder.ApplyConfiguration(new ExpensesTagsFluentMapping());
            modelBuilder.ApplyConfiguration(new SavingsFluentMapping());
            modelBuilder.ApplyConfiguration(new TagFluentMapping());
        }

        public virtual DbSet<Tag> Tags { get; set; }

        public virtual DbSet<Expense> Expenses { get; set; }

        public virtual DbSet<Savings> Savings { get; set; }
    }
}
