using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;

namespace DontWasteFood.Infrastructure.Service
{
    public class PackageService(IPackageRepository packageRepository,
            IStudentRepository studentRepository,
            ICanteenRepository canteenRepository) : IPackageService
    {
        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly IStudentRepository _studentRepository = studentRepository;
        private readonly ICanteenRepository _canteenRepository = canteenRepository;
        
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
