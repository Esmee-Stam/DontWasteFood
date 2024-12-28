using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IRepository
{
    public interface IPackageRepository
    {
        IEnumerable<Package> GetAll();

        IQueryable<Package> GetAllAsync();

        ICollection<Package> GetAllAvailablePackages();

        Package? GetPackageById(Guid id);

        void Add(Package package);

        bool Update(Package package);

        bool Delete(Package package);


    }
}
