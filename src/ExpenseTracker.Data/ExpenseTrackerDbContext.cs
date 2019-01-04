using ExpenseTracker.Data.Entities;
using ExpenseTracker.Data.FluentMappings;
using Microsoft.AspNetCore.Identity;
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
            // rename Identityty tables
            this.IdentityTablesConfiguration(modelBuilder);

            modelBuilder.ApplyConfiguration(new ExpenseFluentMapping());
            modelBuilder.ApplyConfiguration(new ExpensesTagsFluentMapping());
            modelBuilder.ApplyConfiguration(new SavingsFluentMapping());
            modelBuilder.ApplyConfiguration(new TagFluentMapping());
            modelBuilder.ApplyConfiguration(new UserFluentMapping());
        }

        private void IdentityTablesConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RolesClaims");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UsersTokens");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UsersRoles");
            modelBuilder.Entity<IdentityUser>().ToTable("Users");

            // ignore columns
            modelBuilder.Entity<IdentityUser>()
                .Ignore(u => u.PhoneNumber)
                .Ignore(u => u.PhoneNumberConfirmed)
                .Ignore(u => u.TwoFactorEnabled);
        }

        public virtual DbSet<Tag> Tags { get; set; }

        public virtual DbSet<Expense> Expenses { get; set; }

        public virtual DbSet<Savings> Savings { get; set; }
    }
}
