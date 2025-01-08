using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;

namespace DontWasteFood.Infrastructure.Service
{
    public class StudentService(IStudentRepository studentRepository) : IStudentService
    {
        private readonly IStudentRepository _studentRepository = studentRepository;
        public bool AddStudent(Student student)
        {
            if (!student.Is16Yearsold(student.DateOfBirth))
            {
                return false;
            }

            _studentRepository.Add(student);
            return true;
        }

    }
    
}
