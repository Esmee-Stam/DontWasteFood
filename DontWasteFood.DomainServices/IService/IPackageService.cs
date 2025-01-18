using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IService
{
    public interface IPackageService
    {
        bool AddPackage(Package package);
        Task UpdatePackage(Guid packageId, Package package);
        void DeletePackage(Package package);
    }
}
