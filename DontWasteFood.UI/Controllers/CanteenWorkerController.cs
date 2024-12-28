using DontWasteFood.Domain.Enums;
using DontWasteFood.DomainServices;
using DontWasteFood.DomainServices.IService;
using DontWasteFood.UI.Helpers;
using DontWasteFood.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.UI.Controllers
{
    [Authorize(Roles = nameof(UserRole.Kantinemedewerker))]
    public class CanteenWorkerController(
        ICanteenWorkerRepository canteenWorkerRepository, 
        ICanteenService canteenService,
        UserManager<IdentityUser> userManager) : Controller
    {
        private readonly ICanteenWorkerRepository _canteenRepository = canteenWorkerRepository;
        private readonly ICanteenService _canteenService = canteenService;
        private readonly UserManager<IdentityUser> _userManager = userManager;

     
        public async Task<IActionResult> Overview()
        {
            var user = await _userManager.GetUserAsync(User);
            var canteenWorker = _canteenRepository.getUserById(Guid.Parse(user!.Id));

            var model = new AccountViewModel
            {
                Name = canteenWorker != null ? canteenWorker.Name : "Kantinemedewerker",
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult MyCanteen()
        {
            var canteenWorkerId = getIdOfCanteenWorker();

            if (canteenWorkerId == null)
            {
                return View(new List<PackageViewModel>());
            }

            var packages = _canteenService.GetPackagesForCanteen(canteenWorkerId.Value);
            var model = PackageHelper.ConvertToPackageViewModel(packages.ToList());
            return View(model);
        }

        [HttpGet]
        public IActionResult OtherCanteen()
        {
            var canteenWorkerId = getIdOfCanteenWorker();

            if (canteenWorkerId == null)
            {
                return View(new List<PackageViewModel>());
            }

            var packages = _canteenService.GetPackagesForOtherCanteen(canteenWorkerId.Value);
            var model = PackageHelper.ConvertToPackageViewModel(packages.ToList());
            return View(model);
        }

        private Guid? getIdOfCanteenWorker()
        {
            var canteenWorkerId = _userManager.GetUserId(User);
            if (canteenWorkerId == null)
            {
                return null;
            }
            return Guid.Parse(canteenWorkerId);

        }


    }
}
