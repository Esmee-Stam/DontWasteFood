using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IService
{
    public interface IPackageService
    {
        public void UpdatePackage(Package package);
        ICollection<Package>? GetAllReservedPackagesByUserId(string email);

    }
}
