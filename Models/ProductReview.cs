
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SweetBakery.Models
{
    public class ProductReview
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer? Customer { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Please select a rating from 1 to 5 stars.")]
        public int Rating { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 5,
            ErrorMessage = "Your review must be between 5 and 1000 characters.")]
        public string Comment { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
