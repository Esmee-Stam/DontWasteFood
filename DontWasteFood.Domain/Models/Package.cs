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

        public void Is18PlusStatus()
        {
            Is18Plus = Products.Any(p => p.IsAlcoholic);
        }

        public bool CanBeReserved(Student? student = null)
        {
            if (Is18Plus)
            {
                Student? reservedStudent = student ?? ReservedBy;

                if (reservedStudent == null)
                {
                    Console.WriteLine("Reservation failed: No student provided for an 18+ package.");
                    return false;
                }

                // Bereken leeftijd
                var studentAge = DateOfPickUp.Year - reservedStudent.DateOfBirth.Year;
                Console.WriteLine($"Initial Age Calculation: {studentAge}");
                if (DateOfPickUp < reservedStudent.DateOfBirth.AddYears(studentAge))
                {
                    studentAge--;
                    Console.WriteLine("Age adjusted due to pick-up date being before birthday.");
                }
                Console.WriteLine($"Final Age: {studentAge}");

                if (studentAge < 18)
                {
                    Console.WriteLine("Reservation failed: Student is not 18+.");
                    return false;
                }
            }

            if (ReservedBy != null)
            {
                Console.WriteLine("Reservation failed: Package is already reserved.");
                return false;
            }

            if (DateOfPickUp <= DateTime.Now)
            {
                Console.WriteLine("Reservation failed: Pick-up date is not in the future.");
                return false;
            }

            Console.WriteLine("Reservation succeeded.");
            return true;
        }

    }
}