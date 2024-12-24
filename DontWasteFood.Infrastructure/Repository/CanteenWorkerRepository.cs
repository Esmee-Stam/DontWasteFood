using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.Infrastructure.Data;

namespace DontWasteFood.Infrastructure.Repository
{
    public class CanteenWorkerRepository(DontWasteFoodDbContext dbContext) : ICanteenWorkerRepository
    {
        private readonly DontWasteFoodDbContext _dbContext = dbContext;
   
        public void Add(CanteenWorker canteenWorker)
        {
            _dbContext.CanteenWorkers.Add(canteenWorker);
            _dbContext.SaveChanges();
        }

        CanteenWorker? ICanteenWorkerRepository.getUserById(Guid id)
        {
            return _dbContext.CanteenWorkers.FirstOrDefault(cw => cw.IdentityUserId == id.ToString());

        }
    }
}
