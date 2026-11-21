
namespace SweetBakery.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal DeliveryCharge { get; set; } = 30m;

        public decimal GstAmount { get; set; }

        public string Status { get; set; } = "Pending";

        // Delivery and cancellation tracking
        public DateTime? DeliveredAt { get; set; }

        public DateTime? CancelledAt { get; set; }

        // Return tracking
        public DateTime? ReturnRequestedAt { get; set; }

        public string? ReturnReason { get; set; }

        public string? ReturnStatus { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
            = new List<OrderDetail>();

        public ICollection<Payment> Payments { get; set; }
            = new List<Payment>();
    }
}
