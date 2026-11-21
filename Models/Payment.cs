namespace SweetBakery.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public int OrderId { get; set; }

        public Order? Order { get; set; }

        public string PaymentMethod { get; set; } = string.Empty;

        public string PaymentStatus { get; set; } = string.Empty;

        public string? TransactionId { get; set; }

        public string? RazorpayOrderId { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}