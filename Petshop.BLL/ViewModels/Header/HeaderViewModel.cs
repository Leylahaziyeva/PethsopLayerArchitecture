using Petshop.BLL.ViewModels.Category;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.ViewModels.Header
{
    public class HeaderViewModel
    {
        public Logo Logo { get; set; } = null!;
        public ContactInfo ContactInfo { get; set; } = null!;
        public SearchInfo? SearchInfo { get; set; }
        public List<CategoryViewModel> Categories { get; set; } = new();
    }
}
