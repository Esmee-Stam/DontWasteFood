using DontWasteFood.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DontWasteFood.Domain.Models
{
    public class Canteen
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public City City { get; set; }

        [Required]
        public required string CanteenLocation { get; set; } 

        [Required]
        public bool HotMealsOffer { get; set; }

        [JsonIgnore]
        public ICollection<CanteenWorker> CanteenWorkers { get; set; } = new List<CanteenWorker>(); 
    }
}
