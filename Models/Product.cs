using System.ComponentModel.DataAnnotations;

namespace ChilomoniBusinessDirectory.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        // Foreign key to Business
        public int BusinessId { get; set; }

        public Business? Business { get; set; }
    }
}
