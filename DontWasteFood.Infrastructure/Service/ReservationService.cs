using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DontWasteFood.Infrastructure.Service
{
    public class ReservationService : IReservationService
    {
        private readonly IPackageRepository _packageRepository;
        private readonly IStudentRepository _studentRepository;

        public ReservationService(IPackageRepository packageRepository, IStudentRepository studentRepository)
        {
            _packageRepository = packageRepository;
            _studentRepository = studentRepository;
        }

        public ICollection<Package> GetReservationsByStudentId(Guid studentId)
        {
            var reservations = _packageRepository.GetAllAsync()
                .Where(p => p.ReservedBy!.Id == studentId)
                .ToList();
            return reservations;
        }

        public async Task<Package?> ReservePackageAsync(Guid packageId, Guid studentId)
        {
            var package = await _packageRepository.GetPackageByIdAsync(packageId);
            if (package == null || package.ReservedBy != null)
            {
                return null;
            }

            var student = _studentRepository.GetUserById(studentId);
            if (student == null)
            {
                return null;
            }

            var existingReservation = await _packageRepository.GetReservationsByDateForStudent(studentId, package.DateOfPickUp);
            if (existingReservation != null)
            {
                return null;
            }

            if (!package.CanBeReserved(student))
            {
                return null;
            }

            var reserved = await _packageRepository.ReservePackageDirectlyAsync(packageId, studentId);
            if (!reserved)
            {
                return null;
            }

            package.StudentId = studentId;
            package.ReservedBy = student;
            return package;
        }
    }
}
