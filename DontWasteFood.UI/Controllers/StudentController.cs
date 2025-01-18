using DontWasteFood.Domain.Enums;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using DontWasteFood.UI.Helpers;
using DontWasteFood.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DontWasteFood.UI.Controllers
{
    [Authorize(Roles = nameof(UserRole.Student))]
    public class StudentController(
        IStudentRepository studentRepository,
        UserManager<IdentityUser> userManager,
        IPackageRepository packageRepository,
        IReservationService reservationService) : Controller
    {
        private readonly IStudentRepository _studentRepository = studentRepository;
        private readonly UserManager<IdentityUser> _userManager = userManager;
        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly IReservationService _reservationService = reservationService;

        public async Task<IActionResult> Overview()
        {
            var user = await _userManager.GetUserAsync(User);
            var student = _studentRepository.GetUserById(Guid.Parse(user!.Id));
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
            var student = _studentRepository.GetByIdentityId(user!.Id);

            if (student == null)
            {
                return View(new List<PackageViewModel>());
            }

            var studentId = student.Id;
          
            var reservations = _reservationService.GetReservationsByStudentId(studentId);

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
        public IActionResult Recommend(string city, string mealType)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return View(new List<PackageViewModel>());
            }

            var studentCity = _studentRepository.GetCity(Guid.Parse(userId));
            
            if (string.IsNullOrEmpty(city))
            {
                city = studentCity.ToString();
            }

            var packages = _packageRepository.GetAllAvailablePackages(city, mealType);

            var model = PackageHelper.ConvertToPackageViewModel(packages.ToList());

            ViewData["DefaultCity"] = city;
            ViewData["DefaultMealType"] = mealType;

            return View(model);
        }

    }
}
