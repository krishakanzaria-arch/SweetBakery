namespace SweetBakery.Models
{
    public class RazorpayCheckoutViewModel
    {
        public int OrderId { get; set; }

        public string RazorpayOrderId { get; set; } = string.Empty;

        public string KeyId { get; set; } = string.Empty;

        public long AmountInPaise { get; set; }

        public string CustomerName { get; set; } = string.Empty;

        public string CustomerEmail { get; set; } = string.Empty;

        public string CustomerPhone { get; set; } = string.Empty;
    }
}