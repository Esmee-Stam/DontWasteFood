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

            
            package.Products = package.Products.Select(p =>
            {
                var existingProduct = _productRepository.GetProductById(p.Id);
                if (existingProduct != null)
                {
                    return existingProduct;
                }
                return p;
            }).ToList();

            package.Is18PlusStatus();
            _packageRepository.Add(package);
            return true;
        }

        public void UpdatePackage(Package package)
        {
            if (package.ReservedBy == null && package.StudentId == null)
            {
                _packageRepository.Update(package);
            }
        }

        public void DeletePackage(Package package)
        {
            if (package.ReservedBy == null && package.StudentId == null)
            {
                _packageRepository.Delete(package);
            }
        }

        ICollection<Package>? IPackageService.GetAllReservedPackagesByUserId(Guid studentId)
        {
            var student = _studentRepository.getUserById(studentId);

            if (student == null)
            {
                return null;
            }

            return _packageRepository.GetAll()
                .Where(p => p.ReservedBy != null && p.ReservedBy.Id == student.Id)
                .ToList();
        }
    }
}
