using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DontWasteFood.Domain.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public bool IsAlcoholic { get; set; }

        public string? PhotoUrl { get; set; }

        public ICollection<Package> Packages { get; set; } = new List<Package>();
    }
}
