using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using DontWasteFood.UI.Helpers;
using DontWasteFood.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.UI.Controllers
{
    [Authorize]
    public class PackageController : Controller
    {
        private readonly IPackageRepository _packageRepository;
        private readonly IPackageService _packageService;
        private readonly IProductRepository _productRepository;
        private readonly ICanteenService _canteenService;
        private readonly IReservationService _reservationService;
        private readonly ICanteenWorkerRepository _canteenWorkerRepository;
        private readonly UserManager<IdentityUser> _userManager;

        public PackageController(
            IPackageRepository packageRepository,
            IPackageService packageService,
            IProductRepository productRepository,
            ICanteenService canteenService,
            IReservationService reservationService,
            ICanteenWorkerRepository canteenWorkerRepository,
            UserManager<IdentityUser> userManager)
        {
            _packageRepository = packageRepository;
            _packageService = packageService;
            _productRepository = productRepository;
            _canteenService = canteenService;
            _reservationService = reservationService;
            _canteenWorkerRepository = canteenWorkerRepository;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Detail(Guid id)
        {
            var package = await _packageRepository.GetPackageByIdAsync(id);
            if (package == null)
                return RedirectToAction("AccessDenied", "Account");

            var model = PackageHelper.ConvertToPackageWithProductsViewModel(package, package.Products.ToList());
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = nameof(UserRole.CanteenWorker))]
        public async Task<IActionResult> PackageForm(Guid? id)
        {
            var loggedInUserId = _userManager.GetUserId(User);
            if (loggedInUserId == null)
            {
                return RedirectToAction("AccessDenied", "Account");

            }

            var canteenWorker = _canteenWorkerRepository.GetUserByIdentityUserId(loggedInUserId);
            if (canteenWorker == null)
            {
                return RedirectToAction("AccessDenied", "Account");
            }

            var canteen = _canteenService.GetCanteenOfCanteenWorker(canteenWorker.Id);
            if (canteen == null)
            {
                return RedirectToAction("AccessDenied", "Account");
            }

            if (id != null)
            {
                var package = await _packageRepository.GetPackageByIdAsync(id.Value);
                if (package == null || package.ReservedBy != null || !IsUserAuthorizedForPackage(canteen, package))
                {
                    return RedirectToAction("OtherCanteen", "CanteenWorker");
                }

                var products = GetAllProducts();
                var model = PackageHelper.ConvertToPackageWithSelectedProducts(package, products);
                return View(model);
            }
            else
            {
                var products = GetAllProducts();
                var model = new PackageViewModel
                {
                    Name = string.Empty,
                    MealType = MealType.Anders,
                    DateOfPickUp = DateTime.Now,
                    Price = 0m,
                    TimeOfPickUp = DateTime.Today.Add(DateTime.Now.TimeOfDay),
                    Location = canteen.CanteenLocation,
                    City = canteen.City,
                    Products = products.Select(product => new ProductViewModel
                    {
                        ProductId = product.Id,
                        Name = product.Name
                    }).ToList()
                };
                return View(model);
            }
        }

        [HttpPost]
        [Authorize(Roles = nameof(UserRole.CanteenWorker))]
        public async Task<IActionResult> PackageForm(Guid? id, PackageViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");

            }

            var canteenWorker = _canteenWorkerRepository.GetUserByIdentityUserId(user.Id);
            if (canteenWorker == null)
            {
                return RedirectToAction("Login", "Account");

            }

            var selectedProducts = model.SelectedProducts
                .Select(id => _productRepository.GetProductByIdAsync(id).Result)
                .Where(product => product != null)
                .ToList();

            if (!selectedProducts.Any())
            {
                ModelState.AddModelError("SelectedProducts", "Geen producten geselecteerd.");
                return View(model);
            }

            if (id == null)
            {
                var newPackage = new Package
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name,
                    DateOfPickUp = model.DateOfPickUp,
                    TimeOfPickUp = model.TimeOfPickUp,
                    Price = model.Price,
                    MealType = model.MealType,
                    CanteenId = canteenWorker.CanteenId,
                    Products = selectedProducts!
                };

                var success = _packageService.AddPackage(newPackage);
                if (!success)
                {
                    ModelState.AddModelError("", "Failed to add package. Ensure pickup date is within the allowed range.");
                    return View(model);
                }
            }
            else
            {
                var updatedPackage = new Package
                {
                    Id = id.Value,
                    Name = model.Name,
                    DateOfPickUp = model.DateOfPickUp,
                    TimeOfPickUp = model.TimeOfPickUp,
                    Price = model.Price,
                    MealType = model.MealType,
                    Products = selectedProducts!
                };

                try
                {
                    await _packageService.UpdatePackage(id.Value, updatedPackage);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"Error updating package: {ex.Message}");
                    return View(model);
                }
            }

            return RedirectToAction("MyCanteen", "CanteenWorker");
        }

        [HttpPost]
        [Authorize(Roles = nameof(UserRole.CanteenWorker))]
        public async Task<IActionResult> Delete(Guid id)
        {
            var package = await _packageRepository.GetPackageByIdAsync(id);
            if (package == null)
            {
               return RedirectToAction("AccessDenied", "Account");
            }

            _packageService.DeletePackage(package);
            return RedirectToAction("MyCanteen", "CanteenWorker");
        }

        private bool IsUserAuthorizedForPackage(Canteen canteen, Package package)
        {
            return package.Canteen?.CanteenLocation == canteen?.CanteenLocation &&
                   package.Canteen?.City == canteen?.City;
        }

        private List<Product> GetAllProducts()
        {
            return _productRepository.GetAll().ToList();
        }
    }
}
