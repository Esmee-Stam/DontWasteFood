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
            Assert.All(reservedPackages, p => Assert.Equal(student.Id, p.StudentId));
            Assert.NotNull(reservedPackages);
        }
    }
}

        



