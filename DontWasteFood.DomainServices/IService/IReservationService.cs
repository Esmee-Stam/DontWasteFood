using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IService
{
    public interface IReservationService
    {

        Package? ReservePackage(Guid packageId, Guid studentId);
    }
}
