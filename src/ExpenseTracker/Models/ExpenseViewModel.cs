using System;
using System.Collections.Generic;

namespace ExpenseTracker.Models
{
    public class ExpenseViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public double Ammount { get; set; }

        public ICollection<TagViewModel> Tags { get; set; }

        public DateTime DateOfPayment { get; set; }
    }
}
