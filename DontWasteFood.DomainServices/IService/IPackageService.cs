using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IService
{
    public interface IPackageService
    {
        public bool AddPackage(Package package);
        public void UpdatePackage(Package package);
        public void DeletePackage(Package package);
        ICollection<Package>? GetAllReservedPackagesByUserId(string email);

    }
}
