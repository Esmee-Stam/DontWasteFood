using System.ComponentModel.DataAnnotations;

namespace DontWasteFood.Domain.Enums
{
    public enum City
    {
        [Display(Name = "Breda")]
        Breda,

        [Display(Name = "Den Bosch")]
        Den_Bosch,

        [Display(Name = "Tilburg")]
        Tilburg
    }
}
