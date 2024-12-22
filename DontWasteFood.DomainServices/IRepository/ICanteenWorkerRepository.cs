using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices
{
    public interface ICanteenWorkerRepository   
    {
        void Add(CanteenWorker canteenWorker);

        CanteenWorker? getUserById(Guid id);

    }
}
