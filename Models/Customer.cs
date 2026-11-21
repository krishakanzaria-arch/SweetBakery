using System.ComponentModel.DataAnnotations;

namespace SweetBakery.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        public string ApplicationUserId { get; set; } = string.Empty;

        public ApplicationUser? ApplicationUser { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        public string? Address { get; set; }

        public string? City { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}