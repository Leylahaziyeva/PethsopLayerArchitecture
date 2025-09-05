using Microsoft.EntityFrameworkCore;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.Shop;

namespace Petshop.BLL.Services
{
    public class ShopManager : IShopService
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ITagService _tagService;

        public ShopManager(IProductService productService, ICategoryService categoryService, ITagService tagService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _tagService = tagService;
        }

        public async Task<ShopViewModel> GetShopViewModelAsync()
        {
            var products = await _productService.GetAllAsync(include: q => q.Include(p => p.Category!));

            var categories = await _categoryService.GetAllAsync();
            var tags = await _tagService.GetAllAsync();

            var shopViewModel = new ShopViewModel
            {
                Products = products.ToList(),
                Categories = categories.ToList(),
                Tags = tags.ToList()  
            };

            return shopViewModel;
        }
    }
}
