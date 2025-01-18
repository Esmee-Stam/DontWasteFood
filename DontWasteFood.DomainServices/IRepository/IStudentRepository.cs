using DontWasteFood.Domain.Enums;
using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IRepository
{
    public interface IStudentRepository
    {
        void Add(Student student);

        Student? GetUserById(Guid id);

        Student? GetByIdentityId(string identityId);

        City GetCity(Guid id);

    }
}
