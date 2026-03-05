using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}
