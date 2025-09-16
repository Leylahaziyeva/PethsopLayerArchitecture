using Microsoft.AspNetCore.Http;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.ViewModels.Review
{
    public class UpdateReviewViewModel
    {
        public int Id { get; set; }
        public float Rate { get; set; }
        public string? ImageName { get; set; }
        public IFormFile? ImageFile { get; set; }
        public ReviewStatus ReviewStatus { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Description { get; set; }
        public int ProductId { get; set; }
        public string? AppUserId { get; set; }
    }
}
