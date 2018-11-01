using System;

namespace ExpenseTracker.Models
{
    public class PostExpenseViewModel
    {
        public string  Name { get; set; }

        public string ExpenseDescription { get; set; }

        public DateTime DateOfPayment { get; set; }

        public double Ammount { get; set; }

        public string Tags { get; set; }
    }
}
