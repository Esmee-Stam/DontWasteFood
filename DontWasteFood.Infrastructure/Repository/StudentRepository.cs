using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DontWasteFood.Infrastructure.Repository
{
    public class StudentRepository(DontWasteFoodDbContext dbContext) : IStudentRepository
    {
        private readonly DontWasteFoodDbContext _dbContext = dbContext;
        public void Add(Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();

        }

        public Student? getUserByEmail(string email)
        {
            return _dbContext.Students.FirstOrDefault(s => s.EmailAddress == email);
        }

        public Student? GetUserById(Guid studentId)
        {
            return _dbContext.Students
                .SingleOrDefault(s => s.Id.ToString().ToUpper() == studentId.ToString().ToUpper());
        }

        public City GetCity(Guid id)
        {
            var student = _dbContext.Students.FirstOrDefault(s => s.IdentityUserId == id.ToString());
            if (student == null)
            {
                throw new InvalidOperationException($"Student with ID {id} not found.");
            }
            return student.City;
        }

        public Student? GetByIdentityId(string identityId)
        {
            return _dbContext.Students.FirstOrDefault(s => s.IdentityUserId == identityId);
        }
    }
}
