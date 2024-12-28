using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IRepository
{
    public interface ICanteenRepository
    {
        void Add(Canteen canteen);

        Canteen? FindById(Guid canteenId);

        Canteen? FindByLocation(City city, string location);
    }
}
