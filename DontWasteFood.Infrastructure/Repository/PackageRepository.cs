using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DontWasteFood.Infrastructure.Repository
{
    public class PackageRepository(DontWasteFoodDbContext dbContext) : IPackageRepository
    {
        private readonly DontWasteFoodDbContext _dbContext = dbContext;
        public IEnumerable<Package> GetAll()
        {
            return _dbContext.Packages
                .Include(p => p.ReservedBy)
                .Include(p => p.Canteen)
                .ToList();

        }

        public ICollection<Package> GetAllAvailablePackages()
        {
            return _dbContext.Packages
                .Include(p => p.ReservedBy)
                .Include(p => p.Canteen)
                .Where(p => p.ReservedBy == null)
                .ToList();
        }

        
    }
}
