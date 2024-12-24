using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;

namespace DontWasteFood.Infrastructure.Service
{
    public class PackageService(IPackageRepository packageRepository,
            IStudentRepository studentRepository,
            IProductRepository productRepository,
            ICanteenRepository canteenRepository) : IPackageService
    {
        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly IStudentRepository _studentRepository = studentRepository;
        private readonly IProductRepository _productRepository = productRepository;
        private readonly ICanteenRepository _canteenRepository = canteenRepository;

        public Package? GetPackageWithProductsById(Guid id)
        {
            var package = _packageRepository.GetPackageById(id);

            if (package == null)
            {
                return null;
            }

            var products = _productRepository.GetAll()
                .Where(p => p.Packages.Any(pp => pp.PackageId == id))
                .ToList();

            package.Products = products;

            return package;
        }

        ICollection<Package>? IPackageService.GetAllReservedPackagesByUserId(string email)
        {
            var student = _studentRepository.getUserByEmail(email);

            if (student == null)
            {
                return null;
            }

            return _packageRepository.GetAll()
                .Where(p => p.ReservedBy != null && p.ReservedBy.StudentId == student.StudentId)
                .ToList();
        }
    }
}
