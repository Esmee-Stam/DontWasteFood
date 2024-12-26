using DontWasteFood.Domain.Enums;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using DontWasteFood.Infrastructure.Repository;
using DontWasteFood.UI.Helpers;
using DontWasteFood.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.UI.Controllers
{
    [Authorize]
    public class PackageController(IPackageService packageService,
                IPackageRepository packageRepository,
                ICanteenService canteenService,
                UserManager<IdentityUser> userManager) : Controller
    {
        private readonly IPackageService _packageService = packageService;
        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly ICanteenService _canteenService = canteenService;
        private readonly UserManager<IdentityUser> _userManager = userManager;

        [Authorize(Roles = nameof(UserRole.Student))]
        public IActionResult Reservation()
        {
            var studentEmail = _userManager.GetUserName(User);

            if (studentEmail == null)
            {
                return View(new List<PackageViewModel>());
            }

            var reservations = _packageService.GetAllReservedPackagesByUserId(studentEmail);

            if (reservations == null)
            {
                return View(new List<PackageViewModel>());
            }

            var reservationsList = reservations.ToList();

            var model = PackageHelper.ConvertToPackageViewModel(reservationsList);

            return View(model);
        }

        [Authorize(Roles = nameof(UserRole.Student))]
        public IActionResult Recommend()
        {
            var packages = _packageRepository.GetAllAvailablePackages();
            var model = PackageHelper.ConvertToPackageViewModel(packages.ToList());
            return View(model);
        }

        public IActionResult Detail(Guid id)
        {
            var package = _packageService.GetPackageWithProductsById(id);
            if (package == null)
            {
                Console.WriteLine("Package not found");
                return NotFound();
            }

            if (!package.Products.Any())
            {
                Console.WriteLine("No products found in the package");
                return NotFound();
            }

            var model = PackageHelper.ConvertToPackageWithProdcutsViewModel(package, package.Products.ToList());
            return View(model);
        }

        [Authorize(Roles = nameof(UserRole.Kantinemedewerker))]
        public IActionResult MyCanteen()
        {
            var canteenWorkerId = getCanteenWorkerId();

            if (canteenWorkerId == null)
            {
                return View(new List<PackageViewModel>());
            }

            var packages = _canteenService.GetPackagesForCanteen(canteenWorkerId.Value);
            var model = PackageHelper.ConvertToPackageViewModel(packages.ToList());
            return View(model);
        }

        [Authorize(Roles = nameof(UserRole.Kantinemedewerker))]
        public IActionResult OtherCanteen()
        {
            var canteenWorkerId = getCanteenWorkerId();

            if (canteenWorkerId == null)
            {
                return View(new List<PackageViewModel>());
            }

            var packages = _canteenService.GetPackagesForOtherCanteen(canteenWorkerId.Value);
            var model = PackageHelper.ConvertToPackageViewModel(packages.ToList());
            return View(model);
        }

        private Guid? getCanteenWorkerId()
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
