using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels;

namespace Petshop.BLL.Services
{
    public class HomeManager : IHomeService
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly ISliderService _sliderService;
        private readonly IBlogService _blogService;

        public HomeManager(ICategoryService categoryService, IProductService productService, ISliderService sliderService, IBlogService blogService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _sliderService = sliderService;
            _blogService = blogService;
        }

        public async Task<HomeViewModel> GetHomeViewModel()
        {
            var categories = await _categoryService.GetAllAsync(predicate: x => !x.IsDeleted);

            var products = await _productService.GetAllAsync(predicate: x => !x.IsDeleted);

            var sliders = await _sliderService.GetAllAsync();

            var blogs = await _blogService.GetLatestAsync(3);

            var homeViewModel = new HomeViewModel
            {
                Categories = categories.ToList(),
                Products = products.ToList(),
                Sliders = sliders.ToList(),

                PetClothingProducts = await _productService.GetByCategoryAsync("Clothes"),
                PetFoodProducts = await _productService.GetByCategoryAsync("Food"),
                BestSellingProducts = await _productService.GetBestSellingAsync(8),

                Blogs = blogs.ToList()
            };

            return homeViewModel;
        }
    }
}