using Petshop.BLL.ViewModels.Category;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.ViewModels.Product
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? AdditionalInformation { get; set; }

        public decimal Price { get; set; }

        public string? CoverImageName { get; set; }

        public string? CategoryName { get; set; }

        public CategoryViewModel? Category { get; set; }

        public IList<string> Tags { get; set; } = new List<string>();

        public IList<string> ImageNames { get; set; } = [];
    }
}
