using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IService;
using NSubstitute;

namespace DontWasteFood.UI.Test
{
    public class PackageServiceTests
    {

        [Fact]
        public void Student_Can_View_Their_Reserved_Packages()
        {
            //Arrange
            var packageService = NSubstitute.Substitute.For<IPackageService>();

            var mockStudent = new Student
            {
                Id = Guid.NewGuid(),
                Name = "John Doe",
                StudentNumber = "2183811",
                EmailAddress = "j.doe@student.avans.nl",
                City = City.Breda
            };

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
                        ReservedBy = mockStudent,
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
                        ReservedBy = mockStudent,
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

            packageService.GetAllReservedPackagesByUserId(mockStudent.EmailAddress).Returns(mockPackages);

            //Act
            var result = packageService.GetAllReservedPackagesByUserId(mockStudent.EmailAddress);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            Assert.Equal(mockStudent, result.First().ReservedBy);

        }

        [Fact]
        public void Student_Has_No_Reservations()
            {
                //Arrange
                var packageService = NSubstitute.Substitute.For<IPackageService>();
                var mockStudent = new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "John Doe",
                    StudentNumber = "2183811",
                    EmailAddress = "j.doe@student.avans.nl",
                    City = City.Breda
                };

                packageService.GetAllReservedPackagesByUserId(mockStudent.EmailAddress).Returns(new List<Package>());

                //Act
                var result = packageService.GetAllReservedPackagesByUserId(mockStudent.EmailAddress);

                //Assert
                Assert.NotNull(result);
                Assert.Empty(result);
            }
        }
}
