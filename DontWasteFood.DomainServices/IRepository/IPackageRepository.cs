using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IRepository
{
    public interface IPackageRepository
    {

        IQueryable<Package> GetAllAsync();

        IQueryable<Package> GetAllAvailablePackages(string? city, string? mealType);


        Task<Package?> GetPackageByIdAsync(Guid id);
        
        Task<Package> Add(Package package);
        Task<Package> Update(Package package);
        Task<Package> Delete(Package package);

        //void Add(Package package);

        //void Update(Package package);

        //void Delete(Package package);

        Task<Package?> GetReservationsByDateForStudent(Guid studentId, DateTime dateOfPickUp);

        Task<bool> ReservePackageDirectlyAsync(Guid packageId, Guid studentId);



    }
}
