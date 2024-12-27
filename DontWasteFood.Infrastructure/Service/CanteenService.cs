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

        public ICollection<Package> GetPackagesForCanteen(Guid canteenWorkerId)
        {
            var canteenWorker = _canteenWorkerRepository.getUserById(canteenWorkerId);
            if (canteenWorker == null)
            {
                throw new Exception("Canteen worker not found");
            }

            var canteenLocation = _canteenRepository.FindById(canteenWorker.CanteenId)?.CanteenLocation;
            var canteenCity = _canteenRepository.FindById(canteenWorker.CanteenId)?.City;

            var packages = _packageRepository
                .GetAll()
                .Where(p => p.Canteen!.CanteenLocation == canteenLocation && p.Canteen!.City == canteenCity)
                .OrderBy(p => p.DateOfPickUp)
                .ThenBy(p => p.TimeOfPickUp)
                .ToList();

            return packages;
        }

        public ICollection<Package> GetPackagesForOtherCanteen(Guid canteenWorkerId)
        {
            var canteenWorker = _canteenWorkerRepository.getUserById(canteenWorkerId);
            if (canteenWorker == null)
            {
                throw new Exception("Canteen worker not found");
            }

            var canteenLocation = _canteenRepository.FindById(canteenWorker.CanteenId)?.CanteenLocation;
            var canteenCity = _canteenRepository.FindById(canteenWorker.CanteenId)?.City;

            var packages = _packageRepository
                .GetAll()
                .Where(p => p.Canteen!.CanteenLocation != canteenLocation && p.Canteen!.City != canteenCity)
                .OrderBy(p => p.DateOfPickUp)
                .ThenBy(p => p.TimeOfPickUp)
                .ToList();

            return packages;
        }
    }
}
