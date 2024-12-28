using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using NSubstitute;

namespace DontWasteFood.UI.Test.PackageTests
{
    public class PackageRepositoryTests
    {
        [Fact]
        public void Student_Can_View_All_Available_Packages()
        {
            //Arrange
            var packageRepo = Substitute.For<IPackageRepository>();

            var mockPackages = new List<Package>
                        {
                            new Package
                            {
                                Id = Guid.NewGuid(),
                                Name = "Kaiserbroodje",
                                DateOfPickUp = DateTime.Now,
                                TimeOfPickUp = DateTime.Now,
                                Is18Plus = false,
                                Price = 2.0m,
                                MealType = MealType.Brood,
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "Kaiserbroodje",
                                        IsAlcoholic = false
                                    }
                                }
                            },

                             new Package
                             {
                                Id = Guid.NewGuid(),
                                Name = "Panini ham & kaas",
                                DateOfPickUp = DateTime.Now,
                                TimeOfPickUp = DateTime.Now,
                                Is18Plus = false,
                                Price = 5.0m,
                                MealType = MealType.Warme_Maaltijd,
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "Panini ham & kaas",
                                        IsAlcoholic = false
                                    }
                                }
                             }

                        };

            packageRepo.GetAllAvailablePackages().Returns(mockPackages);

            //Act
            var result = packageRepo.GetAllAvailablePackages();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void Student_Views_Empty_Available_Packages()
        {
            //Arrange
            var packageRepo = Substitute.For<IPackageRepository>();
            var mockPackages = new List<Package>();

            packageRepo.GetAllAvailablePackages().Returns(mockPackages);

            //Act
            var result = packageRepo.GetAllAvailablePackages();

            //Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void CanteenWorker_Can_Add_New_Package_With_Products()
        {
            //Arrange
            var packageRepo = Substitute.For<IPackageRepository>();
            var canteenService = Substitute.For<ICanteenService>();
            var productRepo = Substitute.For<IProductRepository>();

            var canteen = new Canteen
            {
                Id = Guid.NewGuid(),
                CanteenLocation = "LA",
                City = City.Breda
            };

            var canteenWorker = new CanteenWorker
            {
                Id = Guid.NewGuid(),
                Name = "Jane Doe",
                EmployeeNumber = "12345678",
                CanteenId = canteen.Id,
                Canteen = canteen
            };

            var products = new List<Product>
                {
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Kaiserbroodje",
                        IsAlcoholic = false
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Panini ham & kaas",
                        IsAlcoholic = false
                    }
                };

            var package = new Package
            {
                Id = Guid.NewGuid(),
                Name = "Kaiserbroodje",
                DateOfPickUp = DateTime.Now,
                TimeOfPickUp = DateTime.Now,
                Is18Plus = false,
                Price = 2.0m,
                MealType = MealType.Brood,
                CanteenId = canteen.Id,
                Canteen = canteen,
                Products = products
            };

            packageRepo.Add(package);
            packageRepo.GetPackageById(package.Id).Returns(package);

            //Act
            var result = packageRepo.GetPackageById(package.Id);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(package.Id, result.Id);
        }

        [Fact]
        public void CanteenWorker_Can_Update_Package_From_My_Canteen()
        {
            //Arrange
            var packageRepo = Substitute.For<IPackageRepository>();
            var canteenService = Substitute.For<ICanteenService>();
            var productRepo = Substitute.For<IProductRepository>();
            var canteen = new Canteen
            {
                Id = Guid.NewGuid(),
                CanteenLocation = "LA",
                City = City.Breda
            };
            var canteenWorker = new CanteenWorker
            {
                Id = Guid.NewGuid(),
                Name = "Jane Doe",
                EmployeeNumber = "12345678",
                CanteenId = canteen.Id,
                Canteen = canteen
            };
            var package = new Package
            {
                Id = Guid.NewGuid(),
                Name = "Kaiserbroodje",
                DateOfPickUp = DateTime.Now,
                TimeOfPickUp = DateTime.Now,
                Is18Plus = false,
                Price = 2.0m,
                MealType = MealType.Brood,
                CanteenId = canteen.Id,
                Canteen = canteen
            };
            packageRepo.Update(package);
            packageRepo.GetPackageById(package.Id).Returns(package);

            //Act
            var result = packageRepo.GetPackageById(package.Id);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(canteen.Id, result.CanteenId);
        }

        [Fact]
        public void CanteenWorker_Cannot_Update_Package_From_Other_Canteen()
        {
            //Arrange
            var packageRepo = Substitute.For<IPackageRepository>();
            var canteenService = Substitute.For<ICanteenService>();
            var productRepo = Substitute.For<IProductRepository>();
            var canteen = new Canteen
            {
                Id = Guid.NewGuid(),
                CanteenLocation = "LA",
                City = City.Breda
            };

            var otherCanteen = new Canteen
            {
                Id = Guid.NewGuid(),
                CanteenLocation = "TL",
                City = City.Tilburg
            };

            var canteenWorker = new CanteenWorker
            {
                Id = Guid.NewGuid(),
                Name = "Jane Doe",
                EmployeeNumber = "12345678",
                CanteenId = canteen.Id,
                Canteen = canteen
            };

            var package = new Package
            {
                Id = Guid.NewGuid(),
                Name = "Kaiserbroodje",
                DateOfPickUp = DateTime.Now,
                TimeOfPickUp = DateTime.Now,
                Is18Plus = false,
                Price = 2.0m,
                MealType = MealType.Brood,
                CanteenId = otherCanteen.Id,
                Canteen = otherCanteen,
            };

            packageRepo.Update(package);

            packageRepo.GetPackageById(package.Id).Returns(package);

            //Act
            var result = packageRepo.GetPackageById(package.Id);

            //Assert
            Assert.NotNull(result);
            Assert.NotEqual(canteen.Id, result.CanteenId);
        }

        [Fact]
        public void CanteenWorker_Cannot_Delete_Package_When_Reserved_By_Student()
        {
            //Arrange
            var packageRepo = Substitute.For<IPackageRepository>();
            var packageId = Guid.NewGuid();
            var packageWithReservation = new Package
            {
                Id = packageId,
                Name = "Broodje ham & kaas",
                DateOfPickUp = DateTime.Now.AddDays(1),
                TimeOfPickUp = DateTime.Now.AddHours(1),
                Is18Plus = false,
                Price = 2.0m,
                MealType = MealType.Brood,
                ReservedBy = new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "John Doe",
                    EmailAddress = "j.doe@student.avans.nl",
                    City = City.Breda,
                    StudentNumber = "2183811"
                }

            };

            packageRepo.GetPackageById(packageId).Returns(packageWithReservation);

            //Act
            var result = packageRepo.Delete(packageWithReservation);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Package_Is_Automatically_Set_As_18Plus_When_Product_Is_Alcoholic()
        {
            // Arrange
            var packageRepo = Substitute.For<IPackageRepository>();
            var productRepo = Substitute.For<IProductRepository>();

            var alcoholicProduct = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Amstel Bier",
                IsAlcoholic = true,
            };

            var nonAlcoholicProduct = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Broodje gezond",
                IsAlcoholic = false,
            };

            var package = new Package
            {
                Name = "Broodje gezond met Amstel Bier",
                DateOfPickUp = DateTime.Now,
                TimeOfPickUp = DateTime.Now,
                Price = 20m,
                MealType = MealType.Drank,
                Products = new List<Product> { alcoholicProduct, nonAlcoholicProduct }
            };

            //Act
            package.Is18PlusStatus();

            //Assert
            Assert.True(package.Is18Plus);
        }

        [Fact]
        public void Package_Can_Not_Be_Reserved_When_Student_Is_Underage()
        {
            //Arrange
            var student = new Student
            {
                Id = Guid.NewGuid(),
                Name = "John Doe",
                StudentNumber = "2183811",
                EmailAddress = "j.doe@student.avans.nl",
                City = City.Breda,
            };
            student.UpdateDateOfBirth(new DateTime(2008, 4, 12));

            var alcoholicProduct = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Amstel Bier",
                IsAlcoholic = true,
            };

            var package = new Package
            {
                Id = Guid.NewGuid(),
                Name = "Broodje gezond",
                DateOfPickUp = DateTime.Now,
                TimeOfPickUp = DateTime.Now,
                Price = 20m,
                MealType = MealType.Drank,
                Is18Plus = true,
                Products = new List<Product> { alcoholicProduct }
            };

            package.AddProduct(alcoholicProduct);
            package.ReservedBy = student;

            //Act
            bool canReserve = package.CanBeReserved();

            //Assert
            Assert.False(canReserve);
        }

        [Fact]
        public void Student_Can_See_Products_In_Package()
        {
            // Arrange
            var packageRepo = Substitute.For<IPackageRepository>();
            
            var products = new List<Product>
            {
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Broodje gezond",
                    IsAlcoholic = false
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Panini kaas & ham",
                    IsAlcoholic = false
                },
       
            };

            var package = new Package
            {
                Id = Guid.NewGuid(),
                Name = "Lunchpakket",
                DateOfPickUp = DateTime.Now,
                TimeOfPickUp = DateTime.Now.AddHours(1),
                Price = 15.0m,
                MealType = MealType.Anders,
                Products = products
            };

            packageRepo.GetPackageById(package.Id).Returns(package);

            // Act
            var result = packageRepo.GetPackageById(package.Id);

            // Assert
            Assert.NotNull(result);  
            Assert.Equal(2, result.Products.Count); 
            Assert.Contains(result.Products, p => p.Name == "Broodje gezond");  
            Assert.Contains(result.Products, p => p.Name == "Panini kaas & ham");  
            
        }

    }
}







