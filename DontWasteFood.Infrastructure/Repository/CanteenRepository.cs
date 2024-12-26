using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.Infrastructure.Data;

namespace DontWasteFood.Infrastructure.Repository
{
    public class CanteenRepository : ICanteenRepository
    {
        private readonly DontWasteFoodDbContext _dbContext;

        public CanteenRepository(DontWasteFoodDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Canteen canteen)
        {
            _dbContext.Canteens.Add(canteen);
            _dbContext.SaveChanges();
        }

        public Canteen? FindById(Guid canteenId)
        {
            return _dbContext.Canteens.FirstOrDefault(c => c.CanteenId == canteenId);
        }

        public Canteen? FindByLocation(City city, string location)
        {
            return _dbContext.Canteens.FirstOrDefault(c => c.City == city && c.CanteenLocation == location);
        }

    }
}
