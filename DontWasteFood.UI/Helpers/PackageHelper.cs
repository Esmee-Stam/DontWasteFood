using DontWasteFood.Domain.Models;
using DontWasteFood.UI.Models;

namespace DontWasteFood.UI.Helpers
{
    public static class PackageHelper
    {
        public static List<PackageViewModel> ConvertToPackageViewModel(List<Package> packages)
        {
            return packages.Select(package => new PackageViewModel
            {
                Name = package.Name,
                DateOfPickUp = package.DateOfPickUp,
                MealType = package.MealType,
                Location = package.Canteen!.CanteenLocation,
                City = package.Canteen!.City.Replace("_", " "),
                Is18Plus = package.Is18Plus,
                Price = package.Price
            }).ToList();
        }
    }
}
