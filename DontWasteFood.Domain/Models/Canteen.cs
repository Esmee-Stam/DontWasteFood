using System.ComponentModel.DataAnnotations;

namespace DontWasteFood.Domain.Models
{
    public class Canteen
    {
        [Key]
        public Guid CanteenId { get; set; }

        [Required]
        public required string City { get; set; }

        [Required]
        public required string CanteenLocation { get; set; } 

        [Required]
        public bool HotMealsOffer { get; set; }

        public ICollection<CanteenWorker> CanteenWorkers { get; set; } = new List<CanteenWorker>(); 
    }
}
