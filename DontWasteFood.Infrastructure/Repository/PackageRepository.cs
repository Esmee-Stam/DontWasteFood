using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DontWasteFood.Infrastructure.Repository
{
    public class PackageRepository(DontWasteFoodDbContext dbContext) : IPackageRepository
    {
        private readonly DontWasteFoodDbContext _dbContext = dbContext;

        public IQueryable<Package> GetAllAsync()
        {
            return _dbContext.Packages
                .Include(p => p.ReservedBy)
                .Include(p => p.Canteen)
                .Include(p => p.Products)
                .AsQueryable();
        }

        public async Task<Package?> GetReservationsByDateForStudent(Guid studentId, DateTime dateOfPickUp)
        {
            return await _dbContext.Packages
                .Include(p => p.ReservedBy)
                .FirstOrDefaultAsync(p => p.StudentId == studentId && p.DateOfPickUp == dateOfPickUp);
        }

        public IQueryable<Package> GetAllAvailablePackages(string? city, string? mealType)
        {
            var query = _dbContext.Packages
                .Include(p => p.ReservedBy)
                .Include(p => p.Canteen)
                .Include(p => p.Products)
                .Where(p => p.ReservedBy == null);

            if (!string.IsNullOrEmpty(city))
            {
                if (Enum.TryParse<City>(city, out var cityEnum))
                {
                    query = query.Where(p => p.Canteen != null && p.Canteen.City == cityEnum);
                }
            }

            if (!string.IsNullOrEmpty(mealType))
            {
                if (Enum.TryParse<MealType>(mealType, out var mealTypeEnum))
                {
                    query = query.Where(p => p.MealType == mealTypeEnum);
                }
            }

            return query;
        }

        public async Task<Package?> GetPackageByIdAsync(Guid id)
        {
            return await _dbContext.Packages
                .Include(p => p.ReservedBy)
                .Include(p => p.Canteen)
                .Include(p => p.Products)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Package> Add(Package package)
        {
            await _dbContext.Packages.AddAsync(package);
            await _dbContext.SaveChangesAsync();
            return package;
        }

        public async Task<Package> Update(Package package)
        {
             _dbContext.Update(package);
            await _dbContext.SaveChangesAsync();
            return package;
        }

        public async Task<Package> Delete(Package package)
        {
            _dbContext.Packages.Remove(package);
            await _dbContext.SaveChangesAsync();
            return package;
        }


        public async Task<bool> ReservePackageDirectlyAsync(Guid packageId, Guid studentId)
        {
            var package = await _dbContext.Packages
                .FirstOrDefaultAsync(p => p.Id == packageId && p.ReservedBy == null);

            if (package == null)
            {
                return false; 
            }

            package.StudentId = studentId;
            package.ReservedBy = await _dbContext.Students.FindAsync(studentId);

            await _dbContext.SaveChangesAsync();
            return true; 
        }

    }
}
