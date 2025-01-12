using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
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
    public class PackageController(IPackageRepository packageRepository, IPackageService packageService) : ControllerBase
    {
        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly IPackageService _packageService = packageService;

        //[Authorize(Policy = nameof(UserRole.Student))]
        //[HttpGet]
        //public ICollection<Package> GetAvailablePackages()
        //{
        //    return _packageRepository.GetAllAvailablePackages();
        //}

        [Authorize(Policy = nameof(UserRole.CanteenWorker))]
        [HttpPost]
        public IActionResult AddPackage([FromBody] Package package)
        {
           

            if (package.Id == Guid.Empty)
            {
                package.Id = Guid.NewGuid();
            }

            _packageService.AddPackage(package);

            return Ok(package);
        }

        [Authorize(Policy = nameof(UserRole.CanteenWorker))]
        [HttpPut("{packageId}")]
        public IActionResult UpdatePackage(Guid packageId, [FromBody] Package updatedPackage)
        {
            var package = _packageRepository.GetPackageById(packageId);
            if (package == null)
            {
                return NotFound();
            }

            if (package.ReservedBy != null && package.StudentId != null)
            {
                return BadRequest("Package cannot be updated");
            }

            package.Id = new Guid();
            package.Name = updatedPackage.Name;
            package.DateOfPickUp = updatedPackage.DateOfPickUp;
            package.TimeOfPickUp = updatedPackage.TimeOfPickUp;
            package.MealType = updatedPackage.MealType;
            package.Price = updatedPackage.Price;
            package.CanteenId = updatedPackage.CanteenId;
            package.Products = updatedPackage.Products;

            _packageService.UpdatePackage(package);
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


    }
}
