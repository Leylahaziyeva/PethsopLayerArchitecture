using Petshop.DAL.DataContext.Entities;

namespace Petshop.DAL.Repositories.Contracts
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<Product>> GetByCategoryAsync(string categoryName);
        Task<List<Product>> GetBestSellingAsync(int count);
        Task<Product?> GetByIdWithDetailsAsync(int id);
    }
}
