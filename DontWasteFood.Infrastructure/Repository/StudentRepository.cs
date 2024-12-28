using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.Infrastructure.Data;

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

        public Student? getUserById(Guid id)
        {
            return _dbContext.Students.FirstOrDefault(s => s.IdentityUserId == id.ToString());
        }


    }
}
