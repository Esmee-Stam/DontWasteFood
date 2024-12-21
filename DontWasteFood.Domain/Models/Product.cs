using System.ComponentModel.DataAnnotations;

namespace DontWasteFood.Domain.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public bool IsAlcoholic { get; set; }

        public string? PhotoUrl { get; set; }   

        public ICollection<Package> Packages { get; set; } = new List<Package>();
    }
}
