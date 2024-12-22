using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.UI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IStudentRepository _studentRepository;
        private readonly ICanteenWorkerRepository _canteenWorkerRepository;
        private readonly ICanteenRepository _canteenRepository;

        public AccountController(UserManager<IdentityUser> userManager, 
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            IStudentRepository studentRepository,
            ICanteenWorkerRepository canteenWorkerRepository,
            ICanteenRepository canteenRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _studentRepository = studentRepository;
            _canteenWorkerRepository = canteenWorkerRepository;
            _canteenRepository = canteenRepository;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult RegisterStudent()
        {
           return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult RegisterCanteenWorker()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterStudent(StudentViewModel model)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                ModelState.AddModelError("", "Already signed in.");
                return View(model);
            }

            if (ModelState.IsValid)
            {
                var role = UserRole.Student.ToString();
                if (!await _roleManager.RoleExistsAsync(role))
                {
                    await _roleManager.CreateAsync(new IdentityRole(role));
                }

                var user = new IdentityUser
                {
                    UserName = model.EmailAddress,
                    Email = model.EmailAddress
                };

                var result = await _userManager.CreateAsync(user, model!.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, role);
                    var student = new Student
                    {
                        StudentId = Guid.NewGuid(),
                        Name = model.Name,
                        StudentNumber = model.StudentNumber,
                        EmailAddress = model.EmailAddress,
                        City = model.StudyCity,
                        IdentityUserId = user.Id
                    };

                    student.UpdateDateOfBirth(model.DateOfBirth);
                    _studentRepository.Add(student);
                    return RedirectToAction("Login", "Account");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterCanteenWorker(CanteenWorkerViewModel model)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                ModelState.AddModelError("", "Already signed in.");
                return View(model);
            }

            if (ModelState.IsValid)
            {
                var role = UserRole.Kantinemedewerker.ToString();
                if (!await _roleManager.RoleExistsAsync(role))
                {
                    await _roleManager.CreateAsync(new IdentityRole(role));
                }

                var user = new IdentityUser
                {
                    UserName = model.EmailAddress,
                    Email = model.EmailAddress
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, role);

                    var canteen = _canteenRepository.findByLocation(model.City, model.CanteenLocation);
                    if(canteen == null)
                    {
                        canteen = new Canteen
                        {
                            CanteenId = Guid.NewGuid(),
                            CanteenLocation = model.CanteenLocation,
                            City = model.City
                        };
                        _canteenRepository.Add(canteen);
                    }

                    var canteenWorker = new CanteenWorker
                    {
                        CanteenWorkerId = Guid.NewGuid(),
                        Name = model.Name,
                        EmployeeNumber = model.EmployeeNumber,
                        IdentityUserId = user.Id,
                        CanteenId = canteen.CanteenId,
                        Canteen = canteen
                    };

                    _canteenWorkerRepository.Add(canteenWorker);
                    return RedirectToAction("Login", "Account");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = "")
        {
            return View(new LoginViewModel { Name = string.Empty, Password = string.Empty, ReturnUrl = returnUrl });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(loginViewModel.Name); 
                if (user != null)
                {
                    await _signInManager.SignOutAsync(); 

                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);

                    if (result.Succeeded)
                    {
                        var roles = await _userManager.GetRolesAsync(user);


                        if (roles.Contains(UserRole.Student.ToString()))
                        {
                            return RedirectToAction("Overview", "Student");
                        }
                        else if (roles.Contains(UserRole.Kantinemedewerker.ToString()))
                        {
                            return RedirectToAction("Overview", "Canteenworker");
                        }

                        return Redirect(loginViewModel.ReturnUrl ?? "/");
                    }
                }
            }

            ModelState.AddModelError("", "Invalid email or password.");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account"); 
        }


    }
}






