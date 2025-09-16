using Petshop.BLL.ViewModels.Category;
using Petshop.BLL.ViewModels.Product;
using Petshop.BLL.ViewModels.Slider;

namespace Petshop.BLL.ViewModels
{
    public class HomeViewModel
    {
        public List<CategoryViewModel> Categories { get; set; } = [];
        public List<ProductViewModel> Products { get; set; } = [];
        public List<ProductViewModel> PetClothingProducts { get; set; } = [];
        public List<ProductViewModel> PetFoodProducts { get; set; } = [];
        public List<ProductViewModel> BestSellingProducts { get; set; } = [];
        public List<SliderViewModel> Sliders { get; set; } = [];
    }
}