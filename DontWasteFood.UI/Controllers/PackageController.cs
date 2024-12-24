using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using DontWasteFood.Infrastructure.Repository;
using DontWasteFood.UI.Helpers;
using DontWasteFood.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.UI.Controllers
{
    public class PackageController(IPackageService packageService,
                IPackageRepository packageRepository,
                UserManager<IdentityUser> userManager) : Controller
    {
        private readonly IPackageService _packageService = packageService;
        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly UserManager<IdentityUser> _userManager = userManager;

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

        public IActionResult Recommend()
        {
            var packages = _packageRepository.GetAllAvailablePackages();
            var model = PackageHelper.ConvertToPackageViewModel(packages.ToList());
            return View(model);
        }
    }
}
