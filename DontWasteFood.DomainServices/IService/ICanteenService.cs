using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IService
{
    public interface ICanteenService
    {
        ICollection<Package> GetPackagesForCanteen(Guid canteenWorkerId);

        ICollection<Package> GetPackagesForOtherCanteen(Guid canteenWorkerId);
    }
}
