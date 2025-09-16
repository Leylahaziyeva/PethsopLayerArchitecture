using Microsoft.AspNetCore.Http;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.ViewModels.Review
{
    public class CreateReviewViewModel
    {
        public float Rate { get; set; }
        public string? ImageName { get; set; }
        public IFormFile? ImageFile { get; set; }
        public ReviewStatus ReviewStatus { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string Description { get; set; } = null!;
        public int ProductId { get; set; }
        public string? AppUserId { get; set; }
    }
}
