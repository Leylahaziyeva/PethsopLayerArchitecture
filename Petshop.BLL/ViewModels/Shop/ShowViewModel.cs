using Petshop.BLL.ViewModels.Category;
using Petshop.BLL.ViewModels.Product;

namespace Petshop.BLL.ViewModels.Shop
{
    public class ShopViewModel
    {
        public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
        public List<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
        public IList<string> TagNames { get; set; } = [];
    }
}