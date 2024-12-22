using DontWasteFood.Domain.Enums;
using DontWasteFood.DomainServices;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.UI.Controllers
{
    [Authorize(Roles = nameof(UserRole.Kantinemedewerker))]
    public class CanteenWorkerController(ICanteenWorkerRepository canteenWorkerRepository, UserManager<IdentityUser> userManager) : Controller
    {
        private readonly ICanteenWorkerRepository _canteenRepository = canteenWorkerRepository;
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

        public IActionResult MyCanteen()
        {
            return View();
        }
    }
}
