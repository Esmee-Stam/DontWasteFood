using DontWasteFood.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace DontWasteFood.UI.Models
{
    public class PackageViewModel
    {
        public Guid PackageId { get; set; }

        [Required(ErrorMessage = "Naam is verplicht.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Datum van ophalen is verplicht.")]
        public DateTime DateOfPickUp { get; set; }

        [Required(ErrorMessage = "Tijd van ophalen is verplicht.")]
        public DateTime TimeOfPickUp { get; set; }

        [Required(ErrorMessage = "Type van maaltijd is verplicht.")]
        public required MealType MealType { get; set; }

        [Required(ErrorMessage = "Locatie is verplicht.")]
        public required string Location { get; set; }

        [Required(ErrorMessage = "Stad is verplicht.")]
        public required City City { get; set; }

        public bool Is18Plus { get; set; }

        [Required(ErrorMessage = "Prijs is verplicht.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Prijs moet groter dan 0 euro zijn.")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }
        public string? ReservedBy { get; set; }
        public List<ProductViewModel> Products = new List<ProductViewModel>();

        [Required(ErrorMessage = "Selecteer minimaal 1 product.")]
        public List<Guid> SelectedProducts { get; set; } = new List<Guid>();

    }
}
