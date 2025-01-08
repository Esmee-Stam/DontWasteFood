using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController(IPackageRepository packageRepository) : ControllerBase
    {
        private readonly IPackageRepository _packageRepository = packageRepository;
        [HttpGet]
        public ICollection<Package> GetAvailablePackages()
        {
            return _packageRepository.GetAllAvailablePackages();
        }
    }
}
