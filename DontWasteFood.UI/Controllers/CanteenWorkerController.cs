using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices;
using DontWasteFood.DomainServices.IService;
using DontWasteFood.UI.Helpers;
using DontWasteFood.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.UI.Controllers
{
    [Authorize(Roles = nameof(UserRole.CanteenWorker))]
    public class CanteenWorkerController(
        ICanteenWorkerRepository canteenWorkerRepository, 
        ICanteenService canteenService,
        UserManager<IdentityUser> userManager) : Controller
    {
        private readonly ICanteenWorkerRepository _canteenWorkerRepository = canteenWorkerRepository;
        private readonly ICanteenService _canteenService = canteenService;
        private readonly UserManager<IdentityUser> _userManager = userManager;

     
        public async Task<IActionResult> Overview()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var canteenWorker = _canteenWorkerRepository.GetUserByIdentityUserId(user.Id);

            var model = new AccountViewModel
            {
                Name = canteenWorker != null ? canteenWorker.Name : "CanteenWorker",
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

            var canteenWorker = _canteenWorkerRepository.GetUserById(canteenWorkerId.Value);
            if (canteenWorker == null || canteenWorker.Canteen == null)
            {
                return View(new List<PackageViewModel>());
            }

            var canteen = canteenWorker.Canteen;

            var packages = _canteenService.GetPackagesForCanteen(canteen.Id);
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

            var canteenWorker = _canteenWorkerRepository.GetUserById(canteenWorkerId.Value);
            if (canteenWorker == null || canteenWorker.Canteen == null)
            {
                return View(new List<PackageViewModel>());
            }


            var canteen = canteenWorker.Canteen;


            var packages = _canteenService.GetPackagesForOtherCanteen(canteen.Id);
            var model = PackageHelper.ConvertToPackageViewModel(packages.ToList());
            return View(model);
        }

        private Guid? getIdOfCanteenWorker()
        {
            var identityUser = _userManager.GetUserAsync(User).Result;
            if (identityUser == null)
            {
                return null;
            }

            var canteenWorker = _canteenWorkerRepository.GetUserByIdentityUserId(identityUser.Id);
            if (canteenWorker == null)
            {
                return null;
            }

            return canteenWorker.Id;

        }

    }
}
