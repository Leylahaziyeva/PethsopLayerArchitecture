using Microsoft.AspNetCore.Http;

namespace Petshop.BLL.ViewModels.Category
{
    public class UpdateCategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string Icon { get; set; } = null!;
        public IFormFile? ImageFile { get; set; } 
        public string? ImageName { get; set; }
        public bool IsDeleted { get; set; }
    }
}