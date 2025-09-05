using Petshop.BLL.ViewModels.Product;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.Services.Contracts
{
    public interface IProductService : ICrudService<Product, ProductViewModel, CreateProductViewModel, UpdateProductViewModel>
    {
        Task<List<ProductViewModel>> GetByCategoryAsync(string categoryName);
        Task<List<ProductViewModel>> GetBestSellingAsync(int count);
        Task<ProductViewModel?> GetByIdWithDetailsAsync(int id);
    }
}
