using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;

namespace DontWasteFood.Infrastructure.Service
{
    public class ReservationService(IPackageRepository packageRepository, IStudentRepository studentRepository) : IReservationService
    {
        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly IStudentRepository _studentRepository = studentRepository;

        public Package? ReservePackage(Guid packageId, Guid studentId)
        {
            var package = _packageRepository.GetPackageById(packageId);

            if (package == null)
            {
                return null;
            }

            if (package.ReservedBy != null)
            {
                return null;
            }

            var student = _studentRepository.getUserById(studentId);

            if (student == null)
            {
                return null;
            }

            var existingReservation = _packageRepository.GetReservationsByDateForStudent(studentId, package.DateOfPickUp);
            if (existingReservation != null)
            {
                return null;
            }

            if (!package.CanBeReserved(student))
            {
                return null;
            }

            if (package.ReservedBy != null)
            {
               throw new Exception("Package is already reserved");
            }

            package.ReservedBy = student;
            package.StudentId = student.Id;
            _packageRepository.Update(package);

            return package;
        }
    }
}
