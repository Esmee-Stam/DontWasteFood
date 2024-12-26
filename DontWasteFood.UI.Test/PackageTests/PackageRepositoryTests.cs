using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
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
                            PackageId = Guid.NewGuid(),
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
                                    ProductId = Guid.NewGuid(),
                                    Name = "Kaiserbroodje",
                                    IsAlcoholic = false
                                }
                            }
                        },

                         new Package
                         {
                            PackageId = Guid.NewGuid(),
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
                                    ProductId = Guid.NewGuid(),
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
    }
}
