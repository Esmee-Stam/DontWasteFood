using DontWasteFood.Domain.Models;

namespace DontWasteFood.DomainServices.IRepository
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product? GetProductById(Guid id);
        Product? GetProductByName(string name);
       
    }
}
