namespace BlazorApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public decimal Rating { get; set; }

        // Navigation properties
        public ICollection<Work> Works { get; set; }

    }
}
