using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;

namespace DontWasteFood.Infrastructure.Service
{
    public class ReservationService(IPackageRepository packageRepository, IStudentRepository studentRepository) : IReservationService
    {
        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly IStudentRepository _studentRepository = studentRepository;

        public bool ReservePackage(Guid packageId, Guid studentId)
        {
            var package = _packageRepository.GetPackageById(packageId);

            if (package == null)
            {
                return false;
            }

            if (package.ReservedBy != null)
            {
                return false;
            }

            var student = _studentRepository.getUserById(studentId);

            if (student == null)
            {
                return false;
            }

            var existingReservation = _packageRepository.GetReservationsByDateForStudent(studentId, package.DateOfPickUp);
            if (existingReservation != null) {
                return false;
            }

            if (!package.CanBeReserved(student))
            {
                return false;
            }

            package.ReservedBy = student;
            package.StudentId = student.Id;
            _packageRepository.Update(package);

            return true;
        }
    }
}
