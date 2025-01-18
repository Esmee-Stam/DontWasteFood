using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IRepository
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Task<Product?> GetProductByIdAsync(Guid id); 
    }
}
