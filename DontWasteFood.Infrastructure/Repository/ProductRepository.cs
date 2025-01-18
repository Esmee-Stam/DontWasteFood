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

        public async Task<Product?> GetProductByIdAsync(Guid id)
        {
            return await _dbContext.Products
                .Include(p => p.Packages)
                .FirstOrDefaultAsync(p => p.Id == id);

        }
    }
}
