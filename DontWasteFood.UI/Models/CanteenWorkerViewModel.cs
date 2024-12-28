using DontWasteFood.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace DontWasteFood.UI.Models
{
    public class CanteenWorkerViewModel
    {
        [Required(ErrorMessage = "Naam is verplicht.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Personeelsnummer is verplicht.")]
        [MinLength(7, ErrorMessage = "Personeelsnummer moet minimaal {0} cijfers lang zijn")]
        [MaxLength(7, ErrorMessage = "Personeelsnummer moet maximaal {0} cijfers lang zijn")]
        public required string EmployeeNumber { get; set; }

        [Required(ErrorMessage = "Stad is verplicht.")]
        public required City City { get; set; }

        [Required(ErrorMessage = "Gebouw van kantine is verplicht.")]
        public required string CanteenLocation { get; set; }

        [Required(ErrorMessage = "Emailadres is verplicht.")]
        [EmailAddress(ErrorMessage = "Ongeldig emailadres.")]
        public required string EmailAddress { get; set; }

        [Required(ErrorMessage = "Wachtwoord is verplicht.")]
        [DataType(DataType.Password)]
        public required  string Password { get; set; }

        [Required(ErrorMessage = "Wachtwoordbevestiging is verplicht.")]
        [Compare("Password", ErrorMessage = "Wachtwoorden komen niet overeen.")]
        [DataType(DataType.Password)]
        public required string PasswordConfirmation { get; set; }

        public UserRole Role { get; set; }
        public string ReturnUrl = "/";


    }
}
