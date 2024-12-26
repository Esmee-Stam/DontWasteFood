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
                PackageId = package.PackageId,
                Name = package.Name,
                DateOfPickUp = package.DateOfPickUp,
                MealType = package.MealType,
                Location = package.Canteen!.CanteenLocation,
                City = package.Canteen!.City,
                Is18Plus = package.Is18Plus,
                Price = package.Price
            }).ToList();
        }

        public static PackageViewModel ConvertToPackageWithProdcutsViewModel(Package package, List<Product> products)
        {
            return new PackageViewModel
            {
                PackageId = package.PackageId,
                Name = package.Name,
                DateOfPickUp = package.DateOfPickUp,
                TimeOfPickUp = package.TimeOfPickUp,
                MealType = package.MealType,
                Location = package.Canteen!.CanteenLocation,
                City = package.Canteen!.City,
                Is18Plus = package.Is18Plus,
                Price = package.Price,
                ReservedBy = package.ReservedBy?.Name,
                Products = products.Select(product => new ProductViewModel
                {
                    Name = product.Name,
                    IsAlcoholic = product.IsAlcoholic,
                    Photo = product.PhotoUrl
                }).ToList()
            };
        }

    }
}

