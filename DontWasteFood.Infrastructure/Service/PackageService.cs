using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;

namespace DontWasteFood.Infrastructure.Service
{
    public class PackageService(IPackageRepository packageRepository,
                        IStudentRepository studentRepository,
                        IProductRepository productRepository) : IPackageService
    {
        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly IStudentRepository _studentRepository = studentRepository;
        private readonly IProductRepository _productRepository = productRepository;


        public bool AddPackage(Package package)
        {
            if (package.DateOfPickUp > DateTime.Now.AddDays(2))
            {
                return false;
            }

            var products = package.Products
                .Select(p => _productRepository.GetProductByIdAsync(p.Id).Result)
                .Where(p => p != null)
                .ToList();

            if (!products.Any())
            {
                return false;
            }

            package.Products = products!;

            package.Is18PlusStatus();

            _packageRepository.Add(package);

            return true;
        }

        public async Task UpdatePackage(Guid packageId, Package package)
        {
            if (package.ReservedBy == null && package.StudentId == null)
            {
                var currentPackage = await _packageRepository.GetPackageByIdAsync(packageId);
                if (currentPackage == null)
                {
                    throw new Exception("Package not found");
                }

                var currentProducts = package.Products
                    .Select(p => _productRepository.GetProductByIdAsync(p.Id).Result)
                    .Where(p => p != null)
                    .ToList();

                currentPackage.Name = package.Name;
                currentPackage.DateOfPickUp = package.DateOfPickUp;
                currentPackage.TimeOfPickUp = package.TimeOfPickUp;
                currentPackage.Price = package.Price;
                currentPackage.MealType = package.MealType;
                currentPackage.Products = currentProducts!;

                currentPackage.Is18PlusStatus();

                await _packageRepository.Update(currentPackage);
            }
        }

        public void DeletePackage(Package package)
        {
            if (package.ReservedBy == null && package.StudentId == null)
            {
                _packageRepository.Delete(package);
            }
        }

    }
}
