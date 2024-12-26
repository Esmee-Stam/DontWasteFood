using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IService
{
    public interface IPackageService
    {
        ICollection<Package>? GetAllReservedPackagesByUserId(string email);

        Package? GetPackageWithProductsById(Guid id);

    }
}
