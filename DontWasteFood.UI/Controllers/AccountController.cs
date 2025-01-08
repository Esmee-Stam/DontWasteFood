using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using DontWasteFood.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.UI.Controllers
{
    [Authorize]
    public class AccountController(UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager,
        IStudentService studentService,
        RoleManager<IdentityRole> roleManager,
        ICanteenWorkerRepository canteenWorkerRepository,
        ICanteenRepository canteenRepository) : Controller
    {
        private readonly UserManager<IdentityUser> _userManager = userManager;
        private readonly SignInManager<IdentityUser> _signInManager = signInManager;
        private readonly RoleManager<IdentityRole> _roleManager = roleManager;
        private readonly IStudentService _studentService = studentService;
        private readonly ICanteenWorkerRepository _canteenWorkerRepository = canteenWorkerRepository;
        private readonly ICanteenRepository _canteenRepository = canteenRepository;

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

            if ((DateTime.Now - model.DateOfBirth).TotalDays / 365 < 16)
            {
                ModelState.AddModelError("DateOfBirth", "Je moet minimaal 16 jaar oud zijn.");
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
                        Id = Guid.NewGuid(),
                        Name = model.Name,
                        StudentNumber = model.StudentNumber,
                        EmailAddress = model.EmailAddress,
                        City = model.City,
                        IdentityUserId = user.Id
                    };

                    student.UpdateDateOfBirth(model.DateOfBirth);
                    _studentService.AddStudent(student);
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

                    var canteen = _canteenRepository.FindByLocation(model.City, model.CanteenLocation);
                    if(canteen == null)
                    {
                        canteen = new Canteen
                        {
                            Id = Guid.NewGuid(),
                            CanteenLocation = model.CanteenLocation,
                            City = model.City
                        };
                        _canteenRepository.Add(canteen);
                    }

                    var canteenWorker = new CanteenWorker
                    {
                        Id = Guid.NewGuid(),
                        Name = model.Name,
                        EmployeeNumber = model.EmployeeNumber,
                        IdentityUserId = user.Id,
                        CanteenId = canteen.Id,
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

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}






