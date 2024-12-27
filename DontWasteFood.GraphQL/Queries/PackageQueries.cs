using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using HotChocolate;

namespace DontWasteFood.GraphQL.Queries
{
    public class PackageQueries
    {
        public IEnumerable<Package> GetPackages([Service] IPackageRepository packageRepository)
        {
            return packageRepository.GetAllAsync();
        }
    }
}
