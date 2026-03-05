using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public decimal Price { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal FinalPrice => 
            DiscountPercentage.HasValue
                ? Price * (1 - DiscountPercentage.Value / 100)
                : Price;

        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}