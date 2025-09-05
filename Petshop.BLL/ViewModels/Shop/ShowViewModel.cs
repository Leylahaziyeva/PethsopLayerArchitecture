using Petshop.BLL.ViewModels.Category;
using Petshop.BLL.ViewModels.Product;
using Petshop.BLL.ViewModels.Tag;

namespace Petshop.BLL.ViewModels.Shop
{
    public class ShopViewModel
    {
        public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
        public List<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
        public List<TagViewModel> Tags { get; set; } = new List<TagViewModel>(); 
    }
}
