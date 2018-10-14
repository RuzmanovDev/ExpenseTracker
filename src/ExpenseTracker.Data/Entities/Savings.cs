namespace ExpenseTracker.Data.Entities
{
    public class Savings : Entity
    {
        public Savings()
        {
        }

        public decimal SavedAmmount { get; set; }

        public string Comment { get; set; }
    }
}
