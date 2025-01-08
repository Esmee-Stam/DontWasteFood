using DontWasteFood.Domain.Models;
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
            if(package.DateOfPickUp > DateTime.Now.AddDays(2))
            {
                return false;   
            }
           _packageRepository.Add(package);
            return true;
        }

        public void UpdatePackage(Package package)
        {
            if(package.ReservedBy == null && package.StudentId == null)
            {
                _packageRepository.Update(package);
                
            }
        }

        public void DeletePackage(Package package)
        {
            if(package.ReservedBy == null && package.StudentId == null)
            {
                _packageRepository.Delete(package);
            }
        }

        ICollection<Package>? IPackageService.GetAllReservedPackagesByUserId(string email)
        {
            var student = _studentRepository.getUserByEmail(email);

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
