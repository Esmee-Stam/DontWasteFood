using DontWasteFood.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace DontWasteFood.UI.Models
{
    public class StudentViewModel
    {
        [Required(ErrorMessage = "Naam is verplicht.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Geboortedatum is verplicht.")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Studentennummer is verplicht.")]
        [MinLength(7, ErrorMessage = "Studentennummer moet minimaal 7 cijfers lang zijn")]
        [MaxLength(7, ErrorMessage = "Studentennummer moet maximaal 7 cijfers lang zijn")]
        public required string StudentNumber { get; set; }

        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Studiestad is verplicht.")]
        public required City City { get; set; }

        [Required(ErrorMessage = "Emailadres is verplicht.")]
        [EmailAddress(ErrorMessage = "Ongeldig emailadres.")]
        public required string EmailAddress { get; set; }

        [Required(ErrorMessage = "Wachtwoord is verplicht.")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Bevesting wachtwoord is verplicht.")]
        [Compare("Password", ErrorMessage = "Wachtwoorden komen niet overeen.")]
        [DataType(DataType.Password)]
        public required string PasswordConfirmation { get; set; }
        public UserRole Role { get; set; }
        public string ReturnUrl = "/";

    }
}
