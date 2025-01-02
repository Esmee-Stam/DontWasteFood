namespace DontWasteFood.DomainServices.IService
{
    public interface IReservationService
    {

        bool ReservePackage(Guid packageId, Guid studentId);
    }
}
