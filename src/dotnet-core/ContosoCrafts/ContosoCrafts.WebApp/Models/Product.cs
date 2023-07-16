

using System.Text.Json;

namespace ContosoCrafts.WebApp.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Website { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
        
    }
}
