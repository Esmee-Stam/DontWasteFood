using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using DontWasteFood.Infrastructure.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController(IPackageRepository packageRepository, IPackageService packageService) : ControllerBase
    {
        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly IPackageService _packageService = packageService;
        [HttpGet]
        public ICollection<Package> GetAvailablePackages()
        {
            return _packageRepository.GetAllAvailablePackages();
        }

        [HttpPost]
        public IActionResult AddPackage([FromBody] Package package)
        {
            if (package.DateOfPickUp > DateTime.Now.AddDays(2))
            {
                return BadRequest("A package can only be added up to 2 days in advance.");
            }

            _packageService.AddPackage(package);
            return Ok(package);
        }

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
    }
}
