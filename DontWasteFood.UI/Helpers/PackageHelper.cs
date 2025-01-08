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
                PackageId = package.Id,
                Name = package.Name,
                DateOfPickUp = package.DateOfPickUp,
                MealType = package.MealType,
                Location = package.Canteen!.CanteenLocation,
                City = package.Canteen!.City,
                Is18Plus = package.Is18Plus,
                ReservedBy = package.ReservedBy?.Name,
                Price = package.Price
            }).ToList();
        }

        public static PackageViewModel ConvertToPackageWithProductsViewModel(Package package, List<Product> products)
        {
            return new PackageViewModel
            {
                PackageId = package.Id,
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

        public static PackageViewModel ConvertToPackageWithSelectedProducts(Package package, List<Product> products)
        {
            return new PackageViewModel
            {
                PackageId = package.Id,
                Name = package.Name,
                MealType = package.MealType,
                Price = package.Price,
                DateOfPickUp = package.DateOfPickUp,
                TimeOfPickUp = package.TimeOfPickUp,
                Location = package.Canteen!.CanteenLocation,
                City = package.Canteen!.City,
                Is18Plus = package.Is18Plus,
                Products = products.Select(product => new ProductViewModel
                {
                    ProductId = product.Id,
                    Name = product.Name
                }).ToList(),
                SelectedProducts = package.Products.Select(p => p.Id).ToList()
            };
        }

    }
}

