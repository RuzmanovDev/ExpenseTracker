using System;

namespace ExpenseTracker.Dto
{
    public class ExpenseDto
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public decimal ExpenseAmount { get; set; }

        public DateTime DateOfPayment { get; set; }

        public string UserId { get; set; }

    }
}
