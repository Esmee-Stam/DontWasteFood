using DontWasteFood.Domain.Enums;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using DontWasteFood.Infrastructure.Repository;
using DontWasteFood.UI.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.UI.Controllers
{
    public class ReservationController(IPackageRepository packageRepository, UserManager<IdentityUser> userManager, IReservationService reservationService, IStudentRepository studentRepository) : Controller
    {
        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly UserManager<IdentityUser> _userManager = userManager;
        private readonly IReservationService _reservationService = reservationService;
        private readonly IStudentRepository _studentRepository = studentRepository;

        [HttpPost]
        [Authorize(Roles = nameof(UserRole.Student))]
        public async Task<IActionResult> Reservation(Guid packageId)
        {
            var package = await _packageRepository.GetPackageByIdAsync(packageId);
            if (package == null)
            {
                return RedirectToAction("AccessDenied", "Account");
            }

            var userId = _userManager.GetUserId(User);
            if (userId == null)
            {
                return RedirectToAction("AccessDenied", "Account");
            }

            var student =  _studentRepository.GetByIdentityId(userId);
            if (student == null)
            {
                return RedirectToAction("AccessDenied", "Account");
            }


            var result = await _reservationService.ReservePackageAsync(packageId, student.Id);

            if (result == null)
            {
                ViewBag.ErrorMessage = "Er is een fout opgetreden bij je reservering. Probeer het opnieuw.";
            }
            else
            {
                ViewBag.SuccessMessage = "Je pakket is succesvol gereserveerd!";
            }

            var model = PackageHelper.ConvertToPackageWithProductsViewModel(package, package.Products.ToList());
            return View(model);
        }

    }
}
