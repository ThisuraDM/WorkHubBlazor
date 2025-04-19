using System.Text.Json.Serialization;

namespace BlazorApp.Models
{
    public class Occupation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        [JsonIgnore]
        public ICollection<WorkerOccupation> WorkerOccupations { get; set; }

    }
}
