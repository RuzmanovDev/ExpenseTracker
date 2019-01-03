namespace ExpenseTracker.Models
{
    public class PagerViewModel
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public object ActionViewModel { get; set; }
        public string UpdateTarget { get; set; }
        public int TotalCount { get; set; }
    }
}
