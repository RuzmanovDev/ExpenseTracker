using System.Collections.Generic;

namespace ExpenseTracker.Data.Repositories
{
    public interface IETData<T> where T : class
    {
        void Add(T entity);
        IEnumerable<T> Get();
        void SaveChanges();
    }
}