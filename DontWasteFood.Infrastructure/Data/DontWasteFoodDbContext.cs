using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DontWasteFood.Infrastructure.Data
{
    public class DontWasteFoodDbContext : DbContext
    {
        public const string SqlSchema = "DontWasteFood";

        public DbSet<Student> Students { get; set; }
        public DbSet<Canteen> Canteens { get; set; }
        public DbSet<CanteenWorker> CanteenWorkers { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Product> Products { get; set; }


        public DontWasteFoodDbContext(DbContextOptions<DontWasteFoodDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(SqlSchema);

            modelBuilder.Entity<Student>().HasIndex(s => s.EmailAddress).IsUnique();
            modelBuilder.Entity<Student>().HasIndex(s => s.StudentNumber).IsUnique();
            modelBuilder.Entity<CanteenWorker>().HasIndex(c => c.EmployeeNumber).IsUnique();


            // Relatie tussen Package en Canteen
            modelBuilder.Entity<Package>()
                .HasOne(p => p.Canteen)
                .WithMany()
                .HasForeignKey(p => p.CanteenId)
                .OnDelete(DeleteBehavior.Restrict);

            //Relatie tussen Package en Product
            modelBuilder.Entity<Package>()
            .HasMany(p => p.Products)
            .WithMany(p => p.Packages);

            // Seeding Canteens
            var canteenId1 = Guid.NewGuid();
            var canteenId2 = Guid.NewGuid();
            var canteenId3 = Guid.NewGuid();

            modelBuilder.Entity<Canteen>().HasData(
                new Canteen
                {
                    Id = canteenId1,
                    City = City.Breda,
                    CanteenLocation = "LA",
                    HotMealsOffer = true,
                },
                 new Canteen
                 {
                     Id = canteenId2,
                     City = City.Den_Bosch,
                     CanteenLocation = "DB",
                     HotMealsOffer = true,
                 },
                 new Canteen
                 {
                     Id = canteenId3,
                     City = City.Tilburg,
                     CanteenLocation = "TI",
                     HotMealsOffer = false,
                 }
            );

            var canteenWorkerId1 = Guid.NewGuid();
            var canteenWorkerId2 = Guid.NewGuid();
            var canteenWorkerId3 = Guid.NewGuid();
            var canteenWorkerId4 = Guid.NewGuid();

            //Seeding CanteenWorkers
            modelBuilder.Entity<CanteenWorker>().HasData(
                new CanteenWorker
                {
                    Id = canteenWorkerId1,
                    Name = "John Doe",
                    EmployeeNumber = "1234567",
                    IdentityUserId = "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f",
                    CanteenId = canteenId1

                },
                new CanteenWorker
                {
                    Id = canteenWorkerId2,
                    Name = "Jan Jansen",
                    EmployeeNumber = "7654321",
                    IdentityUserId = "1dbd6d2b-4efb-4b56-93bc-90799c9beea5",
                    CanteenId = canteenId1
                },

                new CanteenWorker
                {
                    Id = canteenWorkerId3,
                    Name = "Tim Timmermans",
                    EmployeeNumber = "1234577",
                    IdentityUserId = "b1c79773-6d4c-4605-9603-1cf695f0cda3",
                    CanteenId = canteenId3

                },
                new CanteenWorker
                {
                    Id = canteenWorkerId4,
                    Name = "Johan Jansen",
                    EmployeeNumber = "7654322",
                    IdentityUserId = "c49a1c5f-b9ad-49e9-8cb7-7fcb54b3b39a",
                    CanteenId = canteenId1
                }
            );

            // Seeding Students
            var studentId1 = Guid.NewGuid();
            var studentId2 = Guid.NewGuid();
            var studentId3 = Guid.NewGuid();
            var studentId4 = Guid.NewGuid();

            var student1 = new Student
            {
                Id = studentId1,
                Name = "Esmée Stam",
                StudentNumber = "2196911",
                EmailAddress = "el.stam@student.avans.nl",
                IdentityUserId = "a96fda13-9eee-4a49-94b7-ddf4c84ec61e",
                City = City.Breda,

            };
            student1.UpdateDateOfBirth(new DateTime(2004, 8, 31));

            var student2 = new Student
            {
                Id = studentId2,
                Name = "Jane Doe",
                StudentNumber = "2176034",
                EmailAddress = "j.doe@student.avans.nl",
                IdentityUserId = "bbfe56c9-88c2-4a60-9479-18b16d8c4c9d",
                City = City.Den_Bosch,
            };
            student2.UpdateDateOfBirth(new DateTime(2008, 3, 21));

            var student3 = new Student
            {
                Id = studentId3,
                Name = "Norah Jones",
                StudentNumber = "2176035",
                EmailAddress = "n.jones@student.avans.nl",
                IdentityUserId = "ea05a0b1-ea38-4c51-bde9-13c6fbb4b61b",
                City = City.Tilburg,
            };
            student3.UpdateDateOfBirth(new DateTime(2005, 4, 11));

            var student4 = new Student
            {
                Id = studentId4,
                Name = "Evie Smith",
                StudentNumber = "2176036",
                EmailAddress = "e.smith@student.avans.nl",
                IdentityUserId = "c16e4b0b-d7b3-4845-a788-52411e76b5de",
                City = City.Breda,
            };
            student4.UpdateDateOfBirth(new DateTime(2006, 5, 1));
            modelBuilder.Entity<Student>().HasData(student1, student2, student3, student4);

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


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = productId1,
                    Name = "Amstel",
                    IsAlcoholic = true,
                    PhotoUrl = "/images/amstel.jpg"
                },
                new Product
                {
                    Id = productId2,
                    Name = "Broodje gezond",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/broodje-gezond.jpg"
                },
                new Product
                {
                    Id = productId3,
                    Name = "Cola",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/cola.jpg"
                },
                new Product
                {
                    Id = productId4,
                    Name = "Fanta",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/fanta.png"
                },
                new Product
                {
                    Id = productId5,
                    Name = "Fristi",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/fristi.png"
                },
                new Product
                {
                    Id = productId6,
                    Name = "Gevulde Koek",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/gevulde-koek.jpg"
                },
                new Product
                {
                    Id = productId7,
                    Name = "Panini Salami",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/panini-salami.jpg"
                },
                new Product
                {
                    Id = productId8,
                    Name = "Saucijzenbroodje",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/saucijzenbroodje.png"
                },
                new Product
                {
                    Id = productId9,
                    Name = "Spa Blauw",
                    IsAlcoholic = false,
                    PhotoUrl = "/images/spa-blauw.jpg"
                }, new Product
                {
                    Id = productId10,
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
            var packageId5 = Guid.NewGuid();
            var packageId6 = Guid.NewGuid();
            var packageId7 = Guid.NewGuid();
            modelBuilder.Entity<Package>().HasData(
                new Package
                {
                    Id = packageId1,
                    Name = "Gevulde Koek met Fristi",
                    DateOfPickUp = new DateTime(2025, 1, 30),
                    TimeOfPickUp = new DateTime(2025, 1, 30, 16, 0, 0),
                    Is18Plus = false,
                    Price = 5.00m,
                    MealType = MealType.Anders,
                    StudentId = studentId1,
                    CanteenId = canteenId1
                },
                new Package
                {
                    Id = packageId2,
                    Name = "Amstel & Stroopwafel",
                    DateOfPickUp = new DateTime(2025, 1, 31),
                    TimeOfPickUp = new DateTime(2025, 1, 13, 13, 0, 0),
                    Is18Plus = true,
                    Price = 10.00m,
                    MealType = MealType.Drank,
                    StudentId = null,
                    CanteenId = canteenId1
                },
                new Package
                {
                    Id = packageId3,
                    Name = "Broodje Gezond",
                    DateOfPickUp = new DateTime(2025, 1, 30),
                    TimeOfPickUp = new DateTime(2025, 1, 30, 11, 0, 0),
                    Is18Plus = false,
                    Price = 3.00m,
                    MealType = MealType.Brood,
                    StudentId = null,
                    CanteenId = canteenId2
                },
                new Package
                {
                    Id = packageId4,
                    Name = "Panini Salami",
                    DateOfPickUp = new DateTime(2025, 1, 30),
                    TimeOfPickUp = new DateTime(2025, 1, 30, 15, 0, 0),
                    Is18Plus = false,
                    Price = 4.00m,
                    MealType = MealType.Brood,
                    StudentId = null,
                    CanteenId = canteenId2
                },
                new Package
                {
                    Id = packageId5,
                    Name = "Fanta & Saucijzenbroodje",
                    DateOfPickUp = new DateTime(2025, 1, 31),
                    TimeOfPickUp = new DateTime(2025, 1, 31, 14, 0, 0),
                    Is18Plus = false,
                    Price = 4.50m,
                    MealType = MealType.Drank,
                    StudentId = null,
                    CanteenId = canteenId3
                },
                new Package
                {
                    Id = packageId6,
                    Name = "Spa Blauw & Panini Salami",
                    DateOfPickUp = new DateTime(2025, 1, 31),
                    TimeOfPickUp = new DateTime(2025, 1, 31, 16, 30, 0),
                    Is18Plus = false,
                    Price = 5.50m,
                    MealType = MealType.Anders,
                    StudentId = null,
                    CanteenId = canteenId3
                }

            );

            //Seeding PackageProducts
            modelBuilder.Entity<Package>()
                .HasMany(p => p.Products)
                .WithMany(p => p.Packages)
                .UsingEntity(
                    j => j.HasData(
                    // Gevulde Koek met Fristi
                    new { PackagesId = packageId1, ProductsId = productId6 },
                    new { PackagesId = packageId1, ProductsId = productId5 },

                    // Amstel & Stroopwafel
                    new { PackagesId = packageId2, ProductsId = productId1 },
                    new { PackagesId = packageId2, ProductsId = productId10 },

                    // Broodje Gezond
                    new { PackagesId = packageId3, ProductsId = productId2 },

                    // Panini Salami
                    new { PackagesId = packageId4, ProductsId = productId7 },

                    // Fanta & Saucijzenbroodje
                    new { PackagesId = packageId5, ProductsId = productId4 },

                    // Spa Blauw & Panini Salami
                    new { PackagesId = packageId6, ProductsId = productId9 }
                ));


            base.OnModelCreating(modelBuilder);
        }
    }
}
