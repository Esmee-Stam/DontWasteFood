using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices
{
    public interface ICanteenWorkerRepository   
    {
        void Add(CanteenWorker canteenWorker);

        CanteenWorker? GetUserById(Guid id);

        CanteenWorker? GetUserByIdentityUserId(string identityUserId);

    }
}
