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

        public void Add(Package package)
        {
            _dbContext.Add(package);
            _dbContext.SaveChanges();
        }

        public void Update(Package package)
        {
            _dbContext.Update(package);
            _dbContext.SaveChanges();

        }

        public void Delete(Package package)
        {
            _dbContext.Remove(package);
            _dbContext.SaveChanges();
        }


        public IEnumerable<Package> GetAll()
        {
            return _dbContext.Packages
                .Include(p => p.ReservedBy)
                .Include(p => p.Canteen)
                .Include(p => p.Products)
                .ToList();

        }

        public IQueryable<Package> GetAllAsync()
        {
            return _dbContext.Packages
                .Include(p => p.ReservedBy)
                .Include(p => p.Canteen)
                .Include(p => p.Products)
                .AsQueryable();
        }

        public ICollection<Package> GetAllAvailablePackages()
        {
            return _dbContext.Packages
                .Include(p => p.ReservedBy)
                .Include(p => p.Canteen)
                .Include(p => p.Products)
                .Where(p => p.ReservedBy == null)
                .ToList();
        }

        public Package? GetPackageById(Guid id)
        {
            return _dbContext.Packages
                 .Include(p => p.ReservedBy)
                 .Include(p => p.Canteen)
                 .Include(p => p.Products)
                 .FirstOrDefault(p => p.Id == id);
        }

        public Package? GetReservationsByDateForStudent(Guid studentId, DateTime dateOfPickUp)
        {
            return _dbContext.Packages.Include(p => p.ReservedBy).FirstOrDefault(p => p.StudentId == studentId && p.DateOfPickUp == dateOfPickUp);
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


    }
}
