using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using DontWasteFood.Infrastructure.Service;
using NSubstitute;
using System.Linq;

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





