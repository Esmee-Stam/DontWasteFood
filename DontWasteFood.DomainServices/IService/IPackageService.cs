using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IService
{
    public interface IPackageService
    {
        public bool AddPackage(Package package);
        public void UpdatePackage(Guid packageId, Package package);
        public void DeletePackage(Package package);
        ICollection<Package>? GetAllReservedPackagesByUserId(Guid studentId);

    }
}
