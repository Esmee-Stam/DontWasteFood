using DontWasteFood.Domain.Enums;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.UI.Controllers
{
    [Authorize(Roles = nameof(UserRole.Student))]
    public class StudentController(IStudentRepository studentRepository, UserManager<IdentityUser> userManager) : Controller
    {
        private readonly IStudentRepository _studentRepository = studentRepository;
        private readonly UserManager<IdentityUser> _userManager = userManager;

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

        public IActionResult Packages()
        {
            return View();
        }

        public IActionResult Reservation()
        {
            return View();
        }
    }
}
