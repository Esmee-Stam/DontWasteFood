using DontWasteFood.Domain.Enums;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using DontWasteFood.UI.Helpers;
using DontWasteFood.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.UI.Controllers
{
    [Authorize(Roles = nameof(UserRole.Student))]
    public class StudentController(
        IStudentRepository studentRepository,
        UserManager<IdentityUser> userManager,
        IPackageRepository packageRepository,
        IPackageService packageService) : Controller
    {
        private readonly IStudentRepository _studentRepository = studentRepository;
        private readonly UserManager<IdentityUser> _userManager = userManager;
        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly IPackageService _packageService = packageService;

        public async Task<IActionResult> Overview()
        {
            var user = await _userManager.GetUserAsync(User);
            var student = _studentRepository.getUserById(Guid.Parse(user!.Id));
            var model = new AccountViewModel
            {
                Name = student != null ? student.Name : "Student",
                
            };

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = nameof(UserRole.Student))]
        public IActionResult Reservation()
        {
            var user = _userManager.GetUserAsync(User).Result;

            if (user == null)
            {
                return View(new List<PackageViewModel>());
            }

            var reservations = _packageService.GetAllReservedPackagesByUserId(Guid.Parse(user.Id));

            if (reservations == null)
            {
                return View(new List<PackageViewModel>());
            }

            var reservationsList = reservations.ToList();

            var model = PackageHelper.ConvertToPackageViewModel(reservationsList);

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = nameof(UserRole.Student))]
        public IActionResult Recommend()
        {
            var packages = _packageRepository.GetAllAvailablePackages();
            var model = PackageHelper.ConvertToPackageViewModel(packages.ToList());
            return View(model);
        }

    }
}
