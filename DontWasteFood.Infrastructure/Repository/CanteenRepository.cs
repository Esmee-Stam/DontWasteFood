using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.Infrastructure.Data;

namespace DontWasteFood.Infrastructure.Repository
{
    public class CanteenRepository(DontWasteFoodDbContext dbContext) : ICanteenRepository
    {
        private readonly DontWasteFoodDbContext _dbContext = dbContext;
        public void Add(Canteen canteen)
        {
            _dbContext.Canteens.Add(canteen);
            _dbContext.SaveChanges();

        }

        public Canteen? findByLocation(string city, string location)
        {
            return _dbContext.Canteens.FirstOrDefault(c => c.City == city && c.CanteenLocation == location);
        }
    }
}
