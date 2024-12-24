using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IRepository
{
    public interface ICanteenRepository
    {
        void Add(Canteen canteen);

        Canteen? findByLocation(string city, string location);
    }
}
