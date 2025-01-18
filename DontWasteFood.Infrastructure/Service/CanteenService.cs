using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;

namespace DontWasteFood.Infrastructure.Service
{
    public class CanteenService(
                IPackageRepository packageRepository,
                ICanteenRepository canteenRepository,
                ICanteenWorkerRepository canteenWorkerRepository) : ICanteenService
    {

        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly ICanteenRepository _canteenRepository = canteenRepository;
        private readonly ICanteenWorkerRepository _canteenWorkerRepository = canteenWorkerRepository;

        public Canteen? GetCanteenOfCanteenWorker(Guid canteenWorkerId)
        {
            var canteenWorker = _canteenWorkerRepository.GetUserById(canteenWorkerId);
            if (canteenWorker == null)
            {
                throw new Exception("Canteen worker not found");
            }

            var canteen = _canteenRepository.FindById(canteenWorker.CanteenId);
            return canteen;
        }

        public ICollection<Package> GetPackagesForCanteen(Guid canteenId)
        {
            var canteen = _canteenRepository.FindById(canteenId);
            if (canteen == null)
            {
                throw new Exception("Canteen not found");
            }

            var packages = _packageRepository
                .GetAllAsync()
                .Where(p => p.Canteen!.Id == canteen.Id)
                .OrderBy(p => p.DateOfPickUp)
                .ThenBy(p => p.TimeOfPickUp)
                .ToList();

            return packages;
        }

        public ICollection<Package> GetPackagesForOtherCanteen(Guid canteenId)
        {
            var canteen = _canteenRepository.FindById(canteenId);
            if (canteen == null)
            {
                throw new Exception("Canteen not found");
            }

  
            var packages = _packageRepository
                .GetAllAsync()
                .Where(p => p.Canteen!.Id != canteen.Id)
                .OrderBy(p => p.DateOfPickUp)
                .ThenBy(p => p.TimeOfPickUp)
                .ToList();

            return packages;
        }
    }
}
