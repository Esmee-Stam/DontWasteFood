using DontWasteFood.Domain.Models;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DontWasteFood.Infrastructure.Repository
{
    public class ProductRepository(DontWasteFoodDbContext dbContext) : IProductRepository
    {
        private readonly DontWasteFoodDbContext _dbContext = dbContext;
        public List<Product> GetAll()
        {
            return _dbContext.Products
                .Include(p => p.Packages)
                .ToList();
        }

        public Product? GetProductById(Guid id)
        {
            return _dbContext.Products
                .Include(p => p.Packages)
                .FirstOrDefault(p => p.Id == id);
        }

        public Product? GetProductByName(string name)
        {
            return _dbContext.Products
                .Include(p => p.Packages)
                .FirstOrDefault(p => p.Name == name);
        }
    }
}
