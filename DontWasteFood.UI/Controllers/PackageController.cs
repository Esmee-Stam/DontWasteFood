using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using DontWasteFood.Infrastructure.Service;
using DontWasteFood.UI.Helpers;
using DontWasteFood.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DontWasteFood.UI.Controllers
{
    [Authorize]
    public class PackageController(
        IPackageRepository packageRepository,
        IPackageService packageService,
        IProductRepository productRepository,
        ICanteenService canteenService,
        IReservationService reservationService,
        UserManager<IdentityUser> userManager) : Controller
    {
        private readonly IPackageRepository _packageRepository = packageRepository;
        private readonly IPackageService _packageService = packageService;
        private readonly IProductRepository _productRepository = productRepository;
        private readonly ICanteenService _canteenService = canteenService;
        private readonly IReservationService _reservationService = reservationService;
        private readonly UserManager<IdentityUser> _userManager = userManager;

        [HttpGet]
        public IActionResult Detail(Guid id)
        {
            var package = _packageRepository.GetPackageById(id);
            if (package == null)
            {
                return RedirectToAction("AccessDenied", "Account");
            }

            var model = PackageHelper.ConvertToPackageWithProductsViewModel(package, package.Products.ToList());
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = nameof(UserRole.CanteenWorker))]
        public IActionResult PackageForm(Guid? id)
        {
            
            var canteen = GetCurrentCanteen();
            if (canteen == null)
            {
                return RedirectToAction("AccessDenied", "Account");

            }

            if (id != null)
            {
                var package = _packageRepository.GetPackageById(id.Value);
                if (package == null)
                {
                    return RedirectToAction("OtherCanteen", "CanteenWorker");

                }

                if (package.ReservedBy != null)
                {
                    return RedirectToAction("AccessDenied", "Account");
                }

                if (!IsUserAuthorizedForPackage(canteen, package))
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
        public IActionResult PackageForm(Guid? id, PackageViewModel model)
        {
            if (id != null)
            {
                var package = _packageRepository.GetPackageById(id.Value);
                if (package == null)
                {
                    return RedirectToAction("MyCanteen", "CanteenWorker");

                }

                var products = _productRepository
                    .GetAll()
                    .Where(p => model.SelectedProducts.Contains(p.Id))
                    .ToList();

                UpdatePackageFromModel(package, model, products);
                _packageService.UpdatePackage(package);
                return RedirectToAction("MyCanteen", "CanteenWorker");
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    model.Products = GetAllProducts()
                        .Select(product => new ProductViewModel
                        {
                            ProductId = product.Id,
                            Name = product.Name,
                            IsAlcoholic = product.IsAlcoholic,
                            Photo = product.PhotoUrl
                        }).ToList();

                    return View(model);
                }

                var canteen = GetCurrentCanteen();
                model.Location = canteen!.CanteenLocation;
                model.City = canteen.City;

                if (!ValidatePickupDate(model.DateOfPickUp))
                {
                    return View(model);
                }

                var products = _productRepository
                    .GetAll()
                    .Where(p => model.SelectedProducts.Contains(p.Id))
                    .ToList();

                var package = CreateNewPackage(model, canteen, products);
                _packageService.AddPackage(package);
                return RedirectToAction("MyCanteen", "CanteenWorker");
            }
        }

        [HttpPost]
        [Authorize(Roles = nameof(UserRole.CanteenWorker))]
        public IActionResult Delete(Guid id)
        {
            var package = _packageRepository.GetPackageById(id);
            if (package == null)
            {
                return RedirectToAction("AccessDenied", "Account");
            }

            _packageService.DeletePackage(package);
           
            return RedirectToAction("MyCanteen", "CanteenWorker");
        }

        [HttpPost]
        [Authorize(Roles = nameof(UserRole.Student))]
        public IActionResult Reservation(Guid packageId)
        {
            var package = _packageRepository.GetPackageById(packageId);
            if (package == null)
            {
                return RedirectToAction("AccessDenied", "Account");

            }

            var studentId = _userManager.GetUserId(User);
            if (studentId == null)
            {
                return RedirectToAction("AccessDenied", "Account");

            }

            var result = _reservationService.ReservePackage(packageId, Guid.Parse(studentId));

            if (!result)
            {
                if (package.Is18Plus)
                {
                    ViewBag.ErrorMessage = "Je moet 18 jaar of ouder zijn om dit maaltijdpakket te reserveren.";
                }
                else if (package.ReservedBy != null)
                {
                    ViewBag.ErrorMessage = "Helaas, dit maaltijdpakket is al gereserveerd. Kies een ander pakket of probeer het later opnieuw.";
                }


                else
                {
                    ViewBag.ErrorMessage = "Je hebt al een reservering gemaakt op deze afhaaldag. Bekijk andere maaltijdpakketten of probeer het opnieuw.";
                }
            }


            var model = PackageHelper.ConvertToPackageWithProductsViewModel(package, package.Products.ToList());
            return View(model);
        }

        private Guid? GetCurrentCanteenWorkerId()
        {
            var canteenWorkerId = _userManager.GetUserId(User);
            if (canteenWorkerId == null)
            {
                return null;
            }

            return Guid.Parse(canteenWorkerId);
        }

        private Canteen? GetCurrentCanteen()
        {
            var canteenWorkerId = GetCurrentCanteenWorkerId();
            if (canteenWorkerId == null)
            {
                return null;
            }

            return _canteenService.GetCanteenOfCanteenWorker(canteenWorkerId.Value);
        }

        private bool IsUserAuthorizedForPackage(Canteen canteen, Package package)
        {
            return package.Canteen?.CanteenLocation == canteen?.CanteenLocation &&
                   package.Canteen?.City == canteen?.City;
        }

        private bool ValidatePickupDate(DateTime date)
        {
            if (date < DateTime.Now.Date)
            {
                ModelState.AddModelError("DateOfPickUp", "De opgegeven datum kan niet in het verleden liggen.");
                return false;
            }

            if (date > DateTime.Now.AddDays(2))
            {
                ModelState.AddModelError("DateOfPickUp", "De opgegeven datum kan niet meer dan 2 dagen vooruit zijn.");
                return false;
            }

            return true;
        }

        private List<Product> GetAllProducts()
        {
            return _productRepository.GetAll().ToList();
        }

        private void UpdatePackageFromModel(Package package, PackageViewModel model, List<Product> products)
        {
            package.Name = model.Name;
            package.DateOfPickUp = model.DateOfPickUp;
            package.TimeOfPickUp = model.TimeOfPickUp;
            package.MealType = model.MealType;
            package.Is18Plus = model.Is18Plus;
            package.Price = model.Price;
            package.Products = products;
            package.Is18PlusStatus();
        }

        private Package CreateNewPackage(PackageViewModel model, Canteen canteen, List<Product> products)
        {
            var package = new Package
            {
                Name = model.Name,
                DateOfPickUp = model.DateOfPickUp,
                TimeOfPickUp = model.TimeOfPickUp,
                MealType = model.MealType,
                Is18Plus = model.Is18Plus,
                Price = model.Price,
                CanteenId = canteen.Id,
                Canteen = canteen
            };

            foreach (var product in products)
            {
                package.AddProduct(product);
            }

            return package;
        }
    }
}
