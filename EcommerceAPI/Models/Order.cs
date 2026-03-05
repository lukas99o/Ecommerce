namespace EcommerceAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string StreetAddress { get; set; } = null!;
        public string City { get; set; } = null!;
        public string ZipCode { get; set; } = null!;

        public string? OrganizationNumber { get; set; }
        public string? CompanyName { get; set; }
        public string? OrderMarking { get; set; }
        public string? InvoiceEmail { get; set; }

        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();

        public enum OrderStatus
        {
            Pending,
            Paid,
            Shipped,
            Cancelled
        }

        public OrderStatus Status { get; set; } = OrderStatus.Pending;
    }
}
