using Microsoft.EntityFrameworkCore;
using Petshop.DAL.DataContext;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.Repositories.Contracts;

namespace Petshop.DAL.Repositories
{
    public class ProductRepository : EfCoreRepository<Product>, IProductRepository
    {
        private readonly AppDbContext _dbContext;

        public ProductRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetByCategoryAsync(string categoryName)
        {
            return await _dbContext.Products
                .Where(p => p.Category!.Name == categoryName)
                .ToListAsync();
        }

        public async Task<List<Product>> GetBestSellingAsync(int count)
        {
            return await _dbContext.Products
                .OrderByDescending(p => p.Reviews.Count) 
                .Take(count)
                .ToListAsync();
        }

        public async Task<Product?> GetByIdWithDetailsAsync(int id)
        {
            return await _dbContext.Products.Include(p => p.Category).Include(p => p.Images)
                .Include(p => p.ProductTags) .ThenInclude(pt => pt.Tag) 
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
