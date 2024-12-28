using DontWasteFood.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace DontWasteFood.Domain.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public DateTime DateOfBirth { get; protected set; }

        [Required]
        [MaxLength(7)]
        public required string StudentNumber { get; set; }

        [Required]
        [EmailAddress]
        public required string EmailAddress { get; set; }

        [Required]
        [EnumDataType(typeof(City))]
        public required City City { get; set; }

        public string? PhoneNumber { get; set; }

        public string? IdentityUserId { get; set; }

        public ICollection<Package> Packages { get; set; } = new List<Package>();

        public Student(Guid id, string name, DateTime dateOfBirth, string studentNumber, string emailAddress, City city)
        {
            if (dateOfBirth > DateTime.Now)
            {
                throw new Exception("Date of Birth must not be in the future");
            }

            if (!Is16Yearsold(dateOfBirth))
            {
                throw new Exception("Student must be 16 years old");
            }

            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth; 
            StudentNumber = studentNumber;
            EmailAddress = emailAddress;
            City = city;
        }

        public Student() { }

        public void UpdateDateOfBirth(DateTime newDateOfBirth)
        {
            if (newDateOfBirth == DateTime.Now)
            {
                throw new Exception("Birth of date must not be in the future");
            }

            if (!Is16Yearsold(newDateOfBirth))
            {
                throw new Exception("Student must be 16 years old to register");
            }

            DateOfBirth = newDateOfBirth;
        }

        private bool Is16Yearsold(DateTime dateOfBirth)
        {
            return (DateTime.Now - dateOfBirth).TotalDays / 365 >= 16;
        }

        public bool Is18Plus(DateTime pickUpDate)
        {
            return (pickUpDate - DateOfBirth).TotalDays / 365 >= 18;
        }
    }
}

