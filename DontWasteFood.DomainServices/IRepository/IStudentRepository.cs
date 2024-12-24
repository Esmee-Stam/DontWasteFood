using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IRepository
{
    public interface IStudentRepository
    {
        void Add(Student student);

        Student? getUserById(Guid id);

    }
}
