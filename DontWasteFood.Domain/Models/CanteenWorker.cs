using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DontWasteFood.Domain.Models
{
    public class CanteenWorker
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        [MaxLength(7)] 
        public required string EmployeeNumber { get; set; }

        public string? IdentityUserId { get; set; }

        //Relatie met Kantine
        [ForeignKey("Canteen")]
        public Guid CanteenId { get; set; }
        public Canteen? Canteen {  get; set; }
       
    }
}
