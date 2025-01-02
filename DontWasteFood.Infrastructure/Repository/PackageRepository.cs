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
            if(package.DateOfPickUp > DateTime.Now.AddDays(2))
            {
                throw new Exception("The package can only be added 2 days in advance");
            }
            _dbContext.Packages.Add(package);
            _dbContext.SaveChanges();
        }

        public bool Delete(Package package)
        {
            if(package.ReservedBy != null && package.StudentId != null)
            {
                return false;
            }

            _dbContext.Packages.Remove(package);
            _dbContext.SaveChanges();
            return true;
        }

        public IEnumerable<Package> GetAll()
        {
            return _dbContext.Packages
                .Include(p => p.ReservedBy)
                .Include(p => p.Canteen)
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

        public bool Update(Package package)
        {
            //if (package.ReservedBy != null && package.StudentId != null)
            //{
            //    return false;
            //}

            _dbContext.Packages.Update(package);
            _dbContext.SaveChanges();
            return true;
        }


    }
}
