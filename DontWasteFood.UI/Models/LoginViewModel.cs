using System.ComponentModel.DataAnnotations;

namespace DontWasteFood.UI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Vul een emailadres in")]
        [EmailAddress]
        public required string Name { get; set; }

        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "Vul een wachtwoord in")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        public string ReturnUrl = "/";
    }
}
