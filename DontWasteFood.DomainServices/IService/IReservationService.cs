using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IService
{
    public interface IReservationService
    {

        Task<Package?> ReservePackageAsync(Guid packageId, Guid studentId);
        ICollection<Package> GetReservationsByStudentId(Guid studentId);
    }
}
