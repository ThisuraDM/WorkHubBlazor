using System.Text.Json.Serialization;

namespace BlazorApp.Models
{
    public class WorkerOccupation
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public int OccupationId { get; set; }
        public decimal Rate { get; set; }
        public string RateType { get; set; } // "hourly", "taskbased", etc.
        public int Rating { get; set; }
        public string Description { get; set; }

        // Navigation properties
        [JsonIgnore]
        public Occupation Occupation { get; set; }
        [JsonIgnore]
        public Worker Worker { get; set; }
        public ICollection<Work> Works { get; set; }

    }
}
