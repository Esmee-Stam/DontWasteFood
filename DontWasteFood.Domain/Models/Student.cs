using System.ComponentModel.DataAnnotations;

namespace DontWasteFood.Domain.Models
{
    public class Student
    {
        [Key]
        public Guid StudentId { get; set; }

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
        public required string City { get; set; }

        public string? PhoneNumber { get; set; }

        public string? IdentityUserId { get; set; }

        public ICollection<Package> Packages { get; set; } = new List<Package>();

        public Student(Guid studentId, string name, DateTime dateOfBirth, string studentNumber, string emailAddress, string city)
        {
            if (dateOfBirth > DateTime.Now)
            {
                throw new Exception("Date of Birth must not be in the future");
            }

            if (!Is16Yearsold(dateOfBirth))
            {
                throw new Exception("Student must be 16 years old");
            }
            StudentId = studentId;
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
        }

        private bool Is16Yearsold(DateTime dateOfBirth)
        {
            return (DateTime.Now - dateOfBirth).TotalDays / 365 >= 16;
        }

        private bool Is18Plus(DateTime pickUpDate)
        {
            return (pickUpDate - DateOfBirth).TotalDays / 365 >= 18;
        }
    }
}

