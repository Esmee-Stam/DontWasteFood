using DontWasteFood.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DontWasteFood.Domain.Models
{
    public class Package
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public DateTime DateOfPickUp { get; set; }

        [Required]
        public DateTime TimeOfPickUp { get; set; }

        [Required]
        public bool Is18Plus { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        public required MealType MealType { get; set; }

        // Relatie met Student
        [ForeignKey("Student")]
        public Guid? StudentId { get; set; }
        public Student? ReservedBy { get; set; }

        //Relatie met Kantine om locatie op te halen
        [ForeignKey("Canteen")]
        public Guid CanteenId { get; set; }
        public Canteen? Canteen { get; set; }

        //Relatie met Products
        public ICollection<Product> Products { get; set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
            Is18PlusStatus();
        }

        private void Is18PlusStatus()
        {
            Is18Plus = Products.Any(p => p.IsAlcoholic);
        }

        public bool CanBeReserved()
        {
            return StudentId == Guid.Empty && TimeOfPickUp > DateTime.Now;
        }

    }
}