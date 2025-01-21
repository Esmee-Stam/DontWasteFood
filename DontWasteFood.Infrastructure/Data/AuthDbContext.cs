using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DontWasteFood.Infrastructure.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public const string SqlSchema = "Authentication";

        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema(SqlSchema);

            var canteenWorkerRole = new IdentityRole(UserRole.CanteenWorker.ToString());
            canteenWorkerRole.NormalizedName = UserRole.CanteenWorker.ToString().ToUpper();

            var studentRole = new IdentityRole(UserRole.Student.ToString());
            studentRole.NormalizedName = UserRole.Student.ToString().ToUpper();

            builder.Entity<IdentityRole>().HasData(canteenWorkerRole, studentRole);

            //CanteenWorkers
            var canteenWorkerUser = new IdentityUser
            {
                Id = "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f",
                UserName = "j.doe@avans.nl",
                NormalizedUserName = "J.DOE@AVANS.NL",
                Email = "j.doe@avans.nl",
                NormalizedEmail = "J.DOE@AVANS.NL",
                EmailConfirmed = true
            };

            var canteenWorkerUser2 = new IdentityUser
            {
                Id = "b1c79773-6d4c-4605-9603-1cf695f0cda3",
                UserName = "t.timmermans@avans.nl",
                NormalizedUserName = "T.TIMMERMANS@AVANS.NL",
                Email = "t.timmermans@avans.nl",
                NormalizedEmail = "T.TIMMERMANS@AVANS>NL",
                EmailConfirmed = true
            };

            var canteenWorkerUser3 = new IdentityUser
            {
                Id = "c49a1c5f-b9ad-49e9-8cb7-7fcb54b3b39a",
                UserName = "jh.jansen@avans.nl",
                NormalizedUserName = "JH.JANSEN@AVANS.NL",
                Email = "jh.jansen@avans.nl",
                NormalizedEmail = "JH.JANSEN@AVANS.NL",
                EmailConfirmed = true
            };

            var canteenWorkerUser4 = new IdentityUser
            {
                Id = "1dbd6d2b-4efb-4b56-93bc-90799c9beea5",
                UserName = "j.jansen@avans.nl",
                NormalizedUserName = "J.JANSEN@AVANS.NL",
                Email = "j.jansen@avans.nl",
                NormalizedEmail = "J.JANSEN@AVANS>NL",
                EmailConfirmed = true
            };

            //Students
            var studentUser = new IdentityUser
            {
                Id = "a96fda13-9eee-4a49-94b7-ddf4c84ec61e",
                UserName = "el.stam@student.avans.nl",
                NormalizedUserName = "EL.STAM@STUDENT.AVANS.NL",
                Email = "el.stam@student.avans.nl",
                NormalizedEmail = "EL.STAM@STUDENT.AVANS.NL",
                EmailConfirmed = true
            };

            var studentUser2 = new IdentityUser
            {
                Id = "bbfe56c9-88c2-4a60-9479-18b16d8c4c9d",
                UserName = "j.doe@student.avans.nl",
                NormalizedUserName = "J.DOE@STUDENT.AVANS.NL",
                Email = "j.doe@student.avans.nl",
                NormalizedEmail = "J.DOE@STUDENT.AVANS.NL",
                EmailConfirmed = true
            };

            var studentUser3 = new IdentityUser
            {
                Id = "ea05a0b1-ea38-4c51-bde9-13c6fbb4b61b",
                UserName = "n.jones@student.avans.nl",
                NormalizedUserName = "N.JONES@STUDENT.AVANS.NL",
                Email = "n.jones@student.avans.nl",
                NormalizedEmail = "N.JONES@STUDENT.AVANS.NL",
                EmailConfirmed = true
            };

            var studentUser4 = new IdentityUser
            {
                Id = "c16e4b0b-d7b3-4845-a788-52411e76b5de",
                UserName = "e.smith@student.avans.nl",
                NormalizedUserName = "E.SMITH@STUDENT.AVANS.NL",
                Email = "e.smith@student.avans.nl",
                NormalizedEmail = "E.SMITH@STUDENT.AVANS.NL",
                EmailConfirmed = true
            };


            var passwordHasher = new PasswordHasher<IdentityUser>();
            canteenWorkerUser.PasswordHash = passwordHasher.HashPassword(canteenWorkerUser, "Kantine1234!");
            canteenWorkerUser2.PasswordHash = passwordHasher.HashPassword(canteenWorkerUser2, "Kantine1234!");
            canteenWorkerUser3.PasswordHash = passwordHasher.HashPassword(canteenWorkerUser3, "Kantine1234!");
            canteenWorkerUser4.PasswordHash = passwordHasher.HashPassword(canteenWorkerUser4, "Kantine1234!");
            studentUser.PasswordHash = passwordHasher.HashPassword(studentUser, "Student1234!");
            studentUser2.PasswordHash = passwordHasher.HashPassword(studentUser, "Student1234!");
            studentUser3.PasswordHash = passwordHasher.HashPassword(studentUser, "Student1234!");
            studentUser4.PasswordHash = passwordHasher.HashPassword(studentUser, "Student1234!");

            builder.Entity<IdentityUser>().HasData(
                canteenWorkerUser,
                canteenWorkerUser2,
                canteenWorkerUser3,
                canteenWorkerUser4,
                studentUser,
                studentUser2,
                studentUser3,
                studentUser4
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = canteenWorkerRole.Id,
                    UserId = canteenWorkerUser.Id
                },
                new IdentityUserRole<string>
                {
                    RoleId = studentRole.Id,
                    UserId = studentUser.Id
                });

            builder.Entity<IdentityUserClaim<string>>().HasData(
                new IdentityUserClaim<string>
                {
                    Id = 1,
                    UserId = canteenWorkerUser.Id,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = UserRole.CanteenWorker.ToString()
                },
                new IdentityUserClaim<string>
                {
                    Id = 3,
                    UserId = canteenWorkerUser2.Id,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = UserRole.CanteenWorker.ToString()
                },
                new IdentityUserClaim<string>
                {
                    Id = 4,
                    UserId = canteenWorkerUser3.Id,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = UserRole.CanteenWorker.ToString()
                },
                new IdentityUserClaim<string>
                {
                    Id = 5,
                    UserId = canteenWorkerUser4.Id,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = UserRole.CanteenWorker.ToString()
                },
                new IdentityUserClaim<string>
                {
                    Id = 2,
                    UserId = studentUser.Id,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = UserRole.Student.ToString()
                },
                new IdentityUserClaim<string>
                {
                    Id = 6,
                    UserId = studentUser2.Id,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = UserRole.Student.ToString()
                },
                new IdentityUserClaim<string>
                {
                    Id = 7,
                    UserId = studentUser3.Id,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = UserRole.Student.ToString()
                },
                new IdentityUserClaim<string>
                {
                    Id = 8,
                    UserId = studentUser4.Id,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = UserRole.Student.ToString()
                }
            );


            base.OnModelCreating(builder);
        }
    }
}
