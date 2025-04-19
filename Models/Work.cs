namespace BlazorApp.Models
{
    public class Work
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int WorkerOccupationId { get; set; }
        public string Status { get; set; } // "Pending", "InProgress", "Completed", "Cancelled"
        public string Description { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }

        // Navigation properties
        public Customer Customer { get; set; }
        public WorkerOccupation WorkerOccupation { get; set; }
    }
}
