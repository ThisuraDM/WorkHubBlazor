using System.Text.Json.Serialization;

namespace BlazorApp.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Bday { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public bool IsActive { get; set; }
        public string PhoneNo { get; set; }

        // Navigation properties
        [JsonIgnore]
        public ICollection<WorkerOccupation> WorkerOccupations { get; set; }
    }
}
 