using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
namespace ChilomoniBusinessDirectory.Models
{
    public class Business
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;

        public string? Location { get; set; }

        public string? Category { get; set; }

        // Foreign key to IdentityUser
        public string OwnerId { get; set; } = string.Empty;

        [ForeignKey("OwnerId")]
        public IdentityUser? Owner { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
