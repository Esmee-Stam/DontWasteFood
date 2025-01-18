using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using DontWasteFood.Infrastructure.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DontWasteFood.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController(IPackageRepository packageRepository, IPackageService packageService, ICanteenWorkerRepository canteenWorkerRepository, ICanteenService canteenService) : ControllerBase
    {
        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly IPackageService _packageService = packageService;
        private readonly ICanteenWorkerRepository _canteenWorkerRepository = canteenWorkerRepository;
        private readonly ICanteenService _canteenService = canteenService;

      
        [Authorize(Policy = nameof(UserRole.CanteenWorker))]
        [HttpPost]
        public IActionResult AddPackage([FromBody] Package package)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Unauthorized();
            }

            var canteenWorker = _canteenWorkerRepository.getUserById(Guid.Parse(userId));

            if (canteenWorker == null)
            {
                return Unauthorized();
            }

            package.CanteenId = canteenWorker.CanteenId;

            if (package.Id == Guid.Empty)
            {
                package.Id = Guid.NewGuid();
            }

            _packageService.AddPackage(package);

            return Ok(package);
        }

        [Authorize(Policy = nameof(UserRole.CanteenWorker))]
        [HttpPut("{packageId}")]
        public IActionResult UpdatePackage(Guid packageId, [FromBody] Package package)
        {
            var currentPackage = _packageRepository.GetPackageById(packageId);

            if (currentPackage == null)
            {
                return NotFound();
            }

            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Unauthorized();
            }

            var canteenWorker = _canteenWorkerRepository.getUserById(Guid.Parse(userId));

            if (canteenWorker == null)
            {
                return Unauthorized();
            }

            package.CanteenId = canteenWorker.CanteenId;

            currentPackage.Name = package.Name;
            currentPackage.DateOfPickUp = package.DateOfPickUp;
            currentPackage.TimeOfPickUp = package.TimeOfPickUp;
            currentPackage.Price = package.Price;
            currentPackage.MealType = package.MealType;
            currentPackage.Products = package.Products;
            _packageService.UpdatePackage(currentPackage);
            return Ok(package);
        }

        [Authorize(Policy = nameof(UserRole.CanteenWorker))]
        [HttpDelete("{packageId}")]
        public IActionResult DeletePackage(Guid packageId)
        {
            var package = _packageRepository.GetPackageById(packageId);

            if (package == null)
            {
                return NotFound();
            }
            if (package.ReservedBy != null && package.StudentId != null)
            {
                return BadRequest("Package cannot be deleted");
            }

            _packageService.DeletePackage(package);
            return Ok(package);
        }

        [Authorize(Policy = nameof(UserRole.Student))]
        [HttpGet]
        public IActionResult GetAvailablePackages([FromQuery] string? city, [FromQuery] string? mealType)
        {
            var packages = _packageRepository.GetAllAvailablePackages(city, mealType);
            return Ok(packages);

        }

        [HttpGet("{packageId}")]
        public IActionResult GetPackageById(Guid packageId)
        {
            var package = _packageRepository.GetPackageById(packageId);

            return Ok(package);
        }

        [Authorize(Policy = nameof(UserRole.CanteenWorker))]
        [HttpGet("Canteen/{canteenId}")]
        public IActionResult GetPackagesForCanteen(Guid canteenId)
        {
            var packages = _canteenService.GetPackagesForCanteen(canteenId);
            return Ok(packages);
        }

    }
}
