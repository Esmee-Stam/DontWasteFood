using DontWasteFood.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DontWasteFood.Infrastructure.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public const string SqlSchema = "Authentication";

        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema(SqlSchema);

            var canteenWorkerRole = new IdentityRole(UserRole.Kantinemedewerker.ToString());
            canteenWorkerRole.NormalizedName = UserRole.Kantinemedewerker.ToString().ToUpper();

            var studentRole = new IdentityRole(UserRole.Student.ToString());
            studentRole.NormalizedName = UserRole.Student.ToString().ToUpper();

            builder.Entity<IdentityRole>().HasData(canteenWorkerRole, studentRole);

            var canteenWorkerUser = new IdentityUser
            {
                Id = "4fdd4c4d-9cf0-4bfc-b9e4-df0329b7d77f",
                UserName = "j.doe@avans.nl",
                NormalizedUserName = "J.DOE@AVANS.NL",
                Email = "j.doe@avans.nl",
                NormalizedEmail = "J.DOE@AVANS.NL",
                EmailConfirmed = true
            };

            var studentUser = new IdentityUser
            {
                Id = "a96fda13-9eee-4a49-94b7-ddf4c84ec61e",
                UserName = "el.stam@student.avans.nl",
                NormalizedUserName = "EL.STAM@STUDENT.AVANS.NL",
                Email = "el.stam@student.avans.nl",
                NormalizedEmail = "EL.STAM@STUDENT.AVANS.NL",
                EmailConfirmed = true
            };

            var passwordHasher = new PasswordHasher<IdentityUser>();
            canteenWorkerUser.PasswordHash = passwordHasher.HashPassword(canteenWorkerUser, "Kantine1234!");
            studentUser.PasswordHash = passwordHasher.HashPassword(studentUser, "Student1234!");

            builder.Entity<IdentityUser>().HasData(canteenWorkerUser, studentUser);

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

            base.OnModelCreating(builder);
        }
    }
}
