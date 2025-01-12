using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IRepository
{
    public interface IPackageRepository
    {
        IEnumerable<Package> GetAll();

        IQueryable<Package> GetAllAsync();

        ICollection<Package> GetAllAvailablePackages();
        IQueryable<Package> GetAllAvailablePackages(string? city, string? mealType);



        Package? GetPackageById(Guid id);

        void Add(Package package);

        void Update(Package package);

        void Delete(Package package);

        public Package? GetReservationsByDateForStudent(Guid studentId, DateTime dateOfPickUp);

    }
}
