using System.ComponentModel.DataAnnotations;

namespace SweetBakery.Models
{
    public class CheckoutViewModel
    {
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone]
        public string Phone { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = string.Empty;

        [Display(Name = "Payment Method")]
        public string PaymentMethod { get; set; } = "Cash on Delivery";
        public decimal Subtotal { get; set; }

        public decimal DeliveryCharge { get; set; } = 30m;

        public decimal GstAmount { get; set; }

        public decimal TotalAmount { get; set; }
    }
}