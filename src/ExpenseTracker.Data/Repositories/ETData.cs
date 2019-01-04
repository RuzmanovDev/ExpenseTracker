using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpenseTracker.Data.Repositories
{
    public class ETData<T> : IETData<T> where T : class
    {
        private readonly ExpenseTrackerDbContext dbContext;

        public ETData(ExpenseTrackerDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentException("dbContext");
        }

        public IEnumerable<T> Get()
        {
            // to do very bad will crash the app. Add some kind of filtering
            var result = this.dbContext.Set<T>().ToList();

            return result;
        }

        public void Add(T entity)
        {
            var entry = this.dbContext.Entry(entity);
            entry.State = EntityState.Added;
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }
    }
}
