using System;

namespace ExpenseTracker.Services
{
    public class ExpenseDTO
    {
        public string Title { get; internal set; }
        public string Description { get; internal set; }
        public DateTime DateOfPayment { get; internal set; }
        public string UserId { get; internal set; }
    }
}