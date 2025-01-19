using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.Infrastructure.Service;
using NSubstitute;

namespace DontWasteFood.UI.Test.PackageTests
{
    public class PackageServiceTest
    {
        [Fact]
        public void Student_Can_View_All_Available_Packages()
        {
            // Arrange
            var packageRepo = Substitute.For<IPackageRepository>();
            packageRepo.GetAllAvailablePackages(null, null).Returns(new List<Package>
                        {
                            new Package
                            {
                                Id = Guid.NewGuid(),
                                Name = "Broodpakket",
                                MealType = MealType.Brood,
                                DateOfPickUp = DateTime.Now,
                                Price = 1.50M,
                                ReservedBy = null,
                                Canteen = new Canteen
                                {
                                    Id = Guid.NewGuid(),
                                    CanteenLocation = "LA",
                                    City = City.Breda
                                }

                            },

                            new Package
                            {
                                Id = Guid.NewGuid(),
                                Name = "Warmemaaltijd",
                                MealType = MealType.Warme_Maaltijd,
                                DateOfPickUp = DateTime.Now,
                                Price = 2.50M,
                                ReservedBy = new Student
                                {
                                    Id = Guid.NewGuid(),
                                    Name = "John Doe",
                                    StudentNumber = "12345678",
                                    EmailAddress = "j.doe@student.avans.nl",
                                    City = City.Breda

                                },
                                Canteen = new Canteen
                                {
                                    Id = Guid.NewGuid(),
                                    CanteenLocation = "LA",
                                    City = City.Breda
                                },

                            },
                            new Package
                            {
                                Id = Guid.NewGuid(),
                                Name = "Broodpakket",
                                MealType = MealType.Brood,
                                DateOfPickUp = DateTime.Now,
                                Price = 1.50M,
                                ReservedBy = null,
                                Canteen = new Canteen
                                {
                                    Id = Guid.NewGuid(),
                                    CanteenLocation = "LA",
                                    City = City.Breda
                                }
                            },
                    }.AsQueryable());

            // Act
            var availablePackages = packageRepo.GetAllAvailablePackages(null, null)
                .Where(p => p.ReservedBy == null)
                .ToList();

            // Assert
            Assert.NotNull(availablePackages);
            Assert.Equal(2, availablePackages.Count());

        }

        [Fact]
        public void Student_Can_View_Their_Reserved_Packages()
        {
            // Arrange
            var studentId = Guid.NewGuid();
            var packageRepo = Substitute.For<IPackageRepository>();
            var studentRepo = Substitute.For<IStudentRepository>();
            var student = new Student
            {
                Id = studentId,
                Name = "John Doe",
                StudentNumber = "12345678",
                EmailAddress = "j.doe@student.avans.nl",
                City = City.Breda
            };

            studentRepo.Add(student);
            packageRepo.GetAllAsync().Returns(new List<Package>
                    {
                        new Package
                        {
                            Id = Guid.NewGuid(),
                            Name = "Broodpakket",
                            MealType = MealType.Brood,
                            DateOfPickUp = DateTime.Now,
                            Price = 1.50M,
                            ReservedBy = student
                        },
                        new Package
                        {
                            Id = Guid.NewGuid(),
                            Name = "Warmemaaltijd",
                            MealType = MealType.Warme_Maaltijd,
                            DateOfPickUp = DateTime.Now,
                            Price = 2.50M,
                            ReservedBy = new Student
                            {
                                Id = Guid.NewGuid(),
                                Name = "Jane Doe",
                                StudentNumber = "12345678",
                                EmailAddress = "jane.doe@student.avans.nl",
                                City = City.Breda
                            }
                        }
                    }.AsQueryable());

            var service = new ReservationService(packageRepo, studentRepo);

            // Act
            var reservedPackages = service.GetReservationsByStudentId(student.Id);

            // Assert
            Assert.Single(reservedPackages);
            Assert.All(reservedPackages, p => Assert.Equal(student.Id, p.ReservedBy?.Id));
            Assert.NotNull(reservedPackages);
        }

        [Fact]
        public void CanteenWorker_Can_View_Packages_In_Their_Own_Canteen()
        {
            // Arrange
            var canteenRepo = Substitute.For<ICanteenRepository>();
            var canteenWorkerRepo = Substitute.For<ICanteenWorkerRepository>();
            var packageRepo = Substitute.For<IPackageRepository>();

            var canteenWorkerId = new Guid("a91b0570-347b-4e67-9683-84586aac676b");
            var canteenId = new Guid("6705cc03-63d4-4d57-8be5-ccc97aadd2f9");

            canteenWorkerRepo.GetUserById(canteenWorkerId).Returns(new CanteenWorker
            {
                Id = canteenWorkerId,
                Name = "John Doe",
                EmployeeNumber = "12345678",
                Canteen = new Canteen
                {
                    Id = canteenId,
                    City = City.Breda,
                    CanteenLocation = "LA"
                }
            });

            canteenRepo.FindById(canteenId).Returns(new Canteen
            {
                Id = canteenId,
                City = City.Breda,
                CanteenLocation = "LA",
            });

            packageRepo.GetAllAsync().Returns(new List<Package>
            {
                new Package
                {
                    Id = Guid.NewGuid(),
                    Name = "Broodpakket",
                    MealType = MealType.Brood,
                    DateOfPickUp = DateTime.Now,
                    Price = 1.50M,
                    ReservedBy = null,
                    Canteen = new Canteen
                    {
                        Id = canteenId,
                        City = City.Breda,
                        CanteenLocation = "LA"
                    }
                },
                new Package
                {
                    Id = Guid.NewGuid(),
                    Name = "Warmemaaltijd",
                    MealType = MealType.Warme_Maaltijd,
                    DateOfPickUp = DateTime.Now,
                    Price = 2.50M,
                    ReservedBy = null,
                    Canteen = new Canteen
                    {
                        Id = canteenId,
                        City = City.Breda,
                        CanteenLocation = "LA"
                    }
                }
            }.AsQueryable());

            // Act
            var canteenPackages = new CanteenService(packageRepo, canteenRepo, canteenWorkerRepo).GetPackagesForCanteen(canteenId);

            // Assert
            Assert.NotNull(canteenPackages);
            Assert.Equal(2, canteenPackages.Count());
            Assert.All(canteenPackages, p => Assert.Equal(canteenId, p.Canteen?.Id));
        }

        [Fact]
        public void CanteenWorker_Can_View_Packages_In_Other_Canteens()
        {
            // Arrange
            var canteenRepo = Substitute.For<ICanteenRepository>();
            var canteenWorkerRepo = Substitute.For<ICanteenWorkerRepository>();
            var packageRepo = Substitute.For<IPackageRepository>();
            var canteenWorkerId = new Guid("a91b0570-347b-4e67-9683-84586aac676b");
            var canteenId = new Guid("6705cc03-63d4-4d57-8be5-ccc97aadd2f9");
            canteenWorkerRepo.GetUserById(canteenWorkerId).Returns(new CanteenWorker
            {
                Id = canteenWorkerId,
                Name = "John Doe",
                EmployeeNumber = "12345678",
                Canteen = new Canteen
                {
                    Id = canteenId,
                    City = City.Breda,
                    CanteenLocation = "LA"
                }
            });
            canteenRepo.FindById(canteenId).Returns(new Canteen
            {
                Id = canteenId,
                City = City.Breda,
                CanteenLocation = "LA",
            });
            packageRepo.GetAllAsync().Returns(new List<Package>
            {
                new Package
                {
                    Id = Guid.NewGuid(),
                    Name = "Broodpakket",
                    MealType = MealType.Brood,
                    DateOfPickUp = DateTime.Now,
                    Price = 1.50M,
                    ReservedBy = null,
                    Canteen = new Canteen
                    {
                        Id = canteenId,
                        City = City.Breda,
                        CanteenLocation = "LA"
                    }
                },
                new Package
                {
                    Id = Guid.NewGuid(),
                    Name = "Warmemaaltijd",
                    MealType = MealType.Warme_Maaltijd,
                    DateOfPickUp = DateTime.Now,
                    Price = 2.50M,
                    ReservedBy = null,
                    Canteen = new Canteen
                    {
                        Id = Guid.NewGuid(),
                        City = City.Tilburg,
                        CanteenLocation = "TL"
                    }
                }
            }.AsQueryable());

            // Act
            var otherCanteenPackages = new CanteenService(packageRepo, canteenRepo, canteenWorkerRepo).GetPackagesForOtherCanteen(canteenId);
            // Assert
            Assert.NotNull(otherCanteenPackages);
            Assert.Single(otherCanteenPackages);
            Assert.All(otherCanteenPackages, p => Assert.NotEqual(canteenId, p.Canteen?.Id));
        }


        [Fact]
        public async Task Package_With_Id_Should_Return_Correct_Details()
        {
            // Arrange
            var packageRepo = Substitute.For<IPackageRepository>();
            var packageId = Guid.NewGuid();
            var package = new Package
            {
                Id = packageId,
                Name = "Broodpakket",
                MealType = MealType.Brood,
                DateOfPickUp = DateTime.Now,
                Price = 1.50M,
                ReservedBy = null,
                Canteen = new Canteen
                {
                    Id = Guid.NewGuid(),
                    CanteenLocation = "LA",
                    City = City.Breda
                },
                Products = new List<Product>
                {
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Brood",
                        IsAlcoholic = false
                    }
                }
            };
            packageRepo.GetPackageByIdAsync(packageId).Returns(Task.FromResult<Package?>(package));

            // Act
            var packageDetails = await packageRepo.GetPackageByIdAsync(packageId);

            // Assert
            Assert.NotNull(packageDetails);
            Assert.Equal(packageId, packageDetails?.Id);
            Assert.Equal("Broodpakket", packageDetails?.Name);
            Assert.Equal(MealType.Brood, packageDetails?.MealType);
            Assert.Equal(1.50M, packageDetails?.Price);
            Assert.Null(packageDetails?.ReservedBy);
            Assert.NotNull(packageDetails?.Canteen);
            Assert.Equal("LA", packageDetails?.Canteen?.CanteenLocation);
            Assert.Equal(City.Breda, packageDetails?.Canteen?.City);
            Assert.NotNull(packageDetails?.Products);
            Assert.Single(packageDetails?.Products!);
        }

        [Fact]
        public void Student_Can_Filter_On_The_Available_Packages()
        {
            // Arrange
            var packageRepo = Substitute.For<IPackageRepository>();

            var packages = new List<Package>
                {
                    new Package
                    {
                        Id = Guid.NewGuid(),
                        Name = "Broodpakket",
                        MealType = MealType.Brood,
                        DateOfPickUp = DateTime.Now,
                        Price = 1.50M,
                        ReservedBy = null,
                        Canteen = new Canteen
                        {
                            Id = Guid.NewGuid(),
                            CanteenLocation = "LA",
                            City = City.Breda
                        }
                    },
                    new Package
                    {
                        Id = Guid.NewGuid(),
                        Name = "Panini ham & kaas",
                        MealType = MealType.Brood,
                        DateOfPickUp = DateTime.Now,
                        Price = 1.50M,
                        ReservedBy = null,
                        Canteen = new Canteen
                        {
                            Id = Guid.NewGuid(),
                            CanteenLocation = "LA",
                            City = City.Breda
                        }
                    },
                    new Package
                    {
                        Id = Guid.NewGuid(),
                        Name = "Amstel bier",
                        MealType = MealType.Drank,
                        DateOfPickUp = DateTime.Now,
                        Price = 1.75M,
                        ReservedBy = null,
                        Canteen = new Canteen
                        {
                            Id = Guid.NewGuid(),
                            CanteenLocation = "TL",
                            City = City.Tilburg
                        }
                    }
                }.AsQueryable();

            packageRepo.GetAllAvailablePackages(City.Breda.ToString(), MealType.Brood.ToString())
            .Returns(packages.Where(p => p.Canteen != null && p.Canteen.City == City.Breda && p.MealType == MealType.Brood).AsQueryable());


            // Act
            var filterPackages = packageRepo.GetAllAvailablePackages(City.Breda.ToString(), MealType.Brood.ToString()).ToList();

            // Assert
            Assert.NotNull(filterPackages);
            Assert.Equal(2, filterPackages.Count());
            Assert.All(filterPackages, p => Assert.Equal(City.Breda.ToString(), p.Canteen?.City.ToString()));
            Assert.All(filterPackages, p => Assert.Equal(MealType.Brood.ToString(), p.MealType.ToString()));
        }

    }
}





