using DontWasteFood.Domain.Enums;

namespace DontWasteFood.UI.Models
{
    public class PackageViewModel
    {
        public Guid PackageId { get; set; }
        public required string Name { get; set; }
        public DateTime DateOfPickUp { get; set; }
        public DateTime TimeOfPickUp { get; set; }
        public required MealType MealType { get; set; }
        public required string Location { get; set; }
        public required City City { get; set; }
        public bool Is18Plus { get; set; }
        public decimal Price { get; set; }
        public string? ReservedBy { get; set; }
        public List<ProductViewModel> Products = new List<ProductViewModel>();
    }
}
