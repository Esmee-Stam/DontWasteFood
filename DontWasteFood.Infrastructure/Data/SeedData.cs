using DontWasteFood.Domain.Models;
using DontWasteFood.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DontWasteFood.Infrastructure.Data
{
    public static class SeedData
    {
        public static void SeedDatabase(this ModelBuilder builder)
        {

            // Seeding Canteens
            var canteenId1 = Guid.NewGuid();
            var canteenId2 = Guid.NewGuid();

            builder.Entity<Canteen>().HasData(
                new Canteen
                {
                    CanteenId = canteenId1,
                    City = City.Breda.ToString(),
                    CanteenLocation = "LA",
                    HotMealsOffer = true,
                },
                 new Canteen
                 {
                     CanteenId = canteenId2,
                     City = City.Den_Bosch.ToString(),
                     CanteenLocation = "DB",
                     HotMealsOffer = true,
                 }
            );

            var canteenWorkerId1 = Guid.Parse("4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f");
            var canteenWorkerId2 = Guid.NewGuid();

            //Seeding CanteenWorkers
            builder.Entity<CanteenWorker>().HasData(
                new CanteenWorker
                {
                    CanteenWorkerId = canteenWorkerId1,
                    Name = "John Doe",
                    EmployeeNumber = "1234567",
                    IdentityUserId = canteenWorkerId1.ToString(),
                    CanteenId = canteenId1

                },
                new CanteenWorker
                {
                    CanteenWorkerId = canteenWorkerId2,
                    Name = "Jan Jansen",
                    EmployeeNumber = "7654321",
                    CanteenId = canteenId1
                }
            );

            // Seeding Students
            var studentId1 = Guid.Parse("a96fda13-9eee-4a49-94b7-ddf4c84ec61e");
            var studentId2 = Guid.NewGuid();

            var student1 = new Student
            {
                StudentId = studentId1,
                Name = "Esmée Stam",
                StudentNumber = "2196911",
                EmailAddress = "el.stam@student.avans.nl",
                IdentityUserId = studentId1.ToString(),
                City = City.Breda.ToString(),
            };
            student1.UpdateDateOfBirth(new DateTime(2004, 8, 31));


            var student2 = new Student
            {
                StudentId = studentId2,
                Name = "Jane Doe",
                StudentNumber = "2176034",
                EmailAddress = "j.doe@student.avans.nl",
                City = City.Den_Bosch.ToString(),
            };
            student2.UpdateDateOfBirth(new DateTime(2008, 3, 21));
            builder.Entity<Student>().HasData(student1, student2);

            //Seeding Products
            var productId1 = Guid.NewGuid();
            var productId2 = Guid.NewGuid();
            var productId3 = Guid.NewGuid();
            var productId4 = Guid.NewGuid();
            var productId5 = Guid.NewGuid();
            var productId6 = Guid.NewGuid();
            var productId7 = Guid.NewGuid();
            var productId8 = Guid.NewGuid();
            var productId9 = Guid.NewGuid();
            var productId10 = Guid.NewGuid();


            builder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = productId1,
                    Name = "Amstel",
                    IsAlcoholic = true,
                    PhotoUrl = "/images/amstel.jpg"
                },
                new Product
                {
                    ProductId = productId2,
                    Name = "Broodje gezond",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/broodje-gezond.jpg"
                },
                new Product
                {
                    ProductId = productId3,
                    Name = "Cola",
                    IsAlcoholic = true,
                    PhotoUrl = "/images/cola.jpg"
                },
                new Product
                {
                    ProductId = productId4,
                    Name = "Fanta",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/fanta.png"
                },
                new Product
                {
                    ProductId = productId5,
                    Name = "Fristi",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/fristi.png"
                },
                new Product
                {
                    ProductId = productId6,
                    Name = "Gevulde Koek",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/gevulde-koek.jpg"
                },
                new Product
                {
                    ProductId = productId7,
                    Name = "Panini Salami",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/panini-salami.jpg"
                },
                new Product
                {
                    ProductId = productId8,
                    Name = "Saucijzenbroodje",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/saucijzenbroodje.png"
                },
                new Product
                {
                    ProductId = productId9,
                    Name = "Spa Blauw",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/spa-blauw.jpg"
                }, new Product
                {
                    ProductId = productId10,
                    Name = "Stroopwafel",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/stroopwafel.jpg"
                }
            );

            //Seeding Packages
            var packageId1 = Guid.NewGuid();
            var packageId2 = Guid.NewGuid();
            var packageId3 = Guid.NewGuid();
            var packageId4 = Guid.NewGuid();
            builder.Entity<Package>().HasData(
                new Package
                {
                    PackageId = packageId1,
                    Name = "Gevulde Koek met Fristi",
                    DateOfPickUp = new DateTime(2024, 12, 30),
                    TimeOfPickUp = new DateTime(2024, 12, 30, 16, 0, 0),
                    Is18Plus = false,
                    Price = 5.00m,
                    MealType = MealType.Anders.ToString(),
                    StudentId = studentId1,
                    CanteenId = canteenId1
                },
                new Package
                {
                    PackageId = packageId2,
                    Name = "Amstel & Stroopwafel",
                    DateOfPickUp = new DateTime(2024, 12, 13),
                    TimeOfPickUp = new DateTime(2024, 12, 13, 13, 0, 0),
                    Is18Plus = true,
                    Price = 10.00m,
                    MealType = MealType.Drank.ToString(),
                    StudentId = null,
                    CanteenId = canteenId1
                },
                new Package
                {
                    PackageId = packageId3,
                    Name = "Broodje Gezond",
                    DateOfPickUp = new DateTime(2024, 12, 14),
                    TimeOfPickUp = new DateTime(2024, 12, 14, 11, 0, 0),
                    Is18Plus = false,
                    Price = 3.00m,
                    MealType = MealType.Brood.ToString(),
                    StudentId = null,
                    CanteenId = canteenId2
                },
                new Package
                {
                    PackageId = packageId4,
                    Name = "Panini Salami",
                    DateOfPickUp = new DateTime(2024, 12, 20),
                    TimeOfPickUp = new DateTime(2024, 12, 20, 15, 0, 0),
                    Is18Plus = false,
                    Price = 4.00m,
                    MealType = MealType.Brood.ToString(),
                    StudentId = null,
                    CanteenId = canteenId2
                }
            );

            //Seeding PackageProducts
            builder.Entity<Package>()
               .HasMany(p => p.Products)
               .WithMany(p => p.Packages)
               .UsingEntity(j => j.HasData(
                   // Gevulde Koek met Fristi
                   new { PackagesPackageId = packageId1, ProductsProductId = productId6 },
                   new { PackagesPackageId = packageId1, ProductsProductId = productId5 },

                   // Amstel & Stroopwafel
                   new { PackagesPackageId = packageId2, ProductsProductId = productId1 },
                   new { PackagesPackageId = packageId2, ProductsProductId = productId10 },

                   // Broodje Gezond
                   new { PackagesPackageId = packageId3, ProductsProductId = productId2 },

                   // Panini Salami
                   new { PackagesPackageId = packageId4, ProductsProductId = productId7 }
               ));
        }
    }
}
