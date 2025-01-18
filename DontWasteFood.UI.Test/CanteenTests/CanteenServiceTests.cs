//using DontWasteFood.Domain.Models;
//using DontWasteFood.Domain.Enums;
//using DontWasteFood.DomainServices;
//using DontWasteFood.DomainServices.IRepository;
//using NSubstitute;
//using DontWasteFood.DomainServices.IService;

//namespace DontWasteFood.UI.Test;

//public class CanteenServiceTests
//{
   

//    [Fact]
//    public void CanteenWorker_Views_All_Packages_Of_Canteen()
//    {
//        //Arrange
//        var canteenId = Guid.NewGuid();
//        var mockCanteen = new Canteen
//        {
//            Id = canteenId,
//            CanteenLocation = "LA",
//            City = City.Breda

//        };

//        var canteenworker = new CanteenWorker
//        {
//            Id = Guid.NewGuid(),
//            CanteenId = canteenId,
//            Name = "Jane Doe",
//            EmployeeNumber = "12345678"

//        };

//        var package = new Package
//        {
//            Id = Guid.NewGuid(),
//            Name = "Kaiserbroodje",
//            DateOfPickUp = DateTime.Now,
//            TimeOfPickUp = DateTime.Now,
//            Is18Plus = false,
//            Price = 2.0m,
//            MealType = MealType.Brood,
//            CanteenId = canteenId,
//            Products = new List<Product>
//            {
//                new Product
//                {
//                    Id = Guid.NewGuid(),
//                    Name = "Kaiserbroodje",
//                    IsAlcoholic = false
//                }
//            }
//        };
//        var canteenWorkerRepo = NSubstitute.Substitute.For<ICanteenWorkerRepository>();
//        var canteenRepo = NSubstitute.Substitute.For<ICanteenRepository>(); 
//        var packageRepo = NSubstitute.Substitute.For<IPackageRepository>();

//        canteenWorkerRepo.getUserById(canteenworker.Id).Returns(canteenworker);
//        canteenRepo.FindById(canteenworker.CanteenId).Returns(mockCanteen);
//        packageRepo.GetAll().Returns(new List<Package> { package });

//        var canteenService = NSubstitute.Substitute.For<ICanteenService>();

//        //Act
//        var result = canteenService.GetPackagesForCanteen(canteenworker.Id);

//        //Assert
//        Assert.NotNull(result);
//        Assert.Equal(mockCanteen.Id, canteenworker.CanteenId);
//        Assert.Equal(mockCanteen.Id, package.CanteenId);

//    }

//    [Fact]
//    public void CanteenWorker_Views_All_Packages_Of_Other_Canteen()
//    {
//        //Arrange
//        var canteenId1 = Guid.NewGuid();
//        var canteenId2 = Guid.NewGuid();
//        var mockCanteen = new Canteen
//        {
//            Id = canteenId1,
//            CanteenLocation = "LA",
//            City = City.Breda

//        };

//        var canteenworker = new CanteenWorker
//        {
//            Id = Guid.NewGuid(),
//            CanteenId = canteenId2,
//            Name = "Jane Doe",
//            EmployeeNumber = "12345678"

//        };

//        var package = new Package
//        {
//            Id = Guid.NewGuid(),
//            Name = "Panini Salami",
//            DateOfPickUp = DateTime.Now,
//            TimeOfPickUp = DateTime.Now,
//            Is18Plus = false,
//            Price = 2.0m,
//            MealType = MealType.Brood,
//            CanteenId = canteenId1,
//            Products = new List<Product>
//            {
//                new Product
//                {
//                    Id = Guid.NewGuid(),
//                    Name = "Panini Salami",
//                    IsAlcoholic = false
//                }
//            }
//        };
//        var canteenWorkerRepo = NSubstitute.Substitute.For<ICanteenWorkerRepository>();
//        var canteenRepo = NSubstitute.Substitute.For<ICanteenRepository>();
//        var packageRepo = NSubstitute.Substitute.For<IPackageRepository>();

//        canteenWorkerRepo.getUserById(canteenworker.Id).Returns(canteenworker);
//        canteenRepo.FindById(canteenworker.CanteenId).Returns(mockCanteen);
//        packageRepo.GetAll().Returns(new List<Package> { package });

//        var canteenService = NSubstitute.Substitute.For<ICanteenService>();

//        //Act
//        var result = canteenService.GetPackagesForCanteen(canteenworker.Id);

//        //Assert
//        Assert.NotNull(result);
//        Assert.NotEqual(mockCanteen.Id, canteenworker.CanteenId);
//        Assert.Equal(mockCanteen.Id, package.CanteenId);
//    }
//}
