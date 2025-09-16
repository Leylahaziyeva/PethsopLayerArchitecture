namespace Petshop.BLL.ViewModels.Review
{
    public class ReviewViewModel
    {
        public int Id { get; set; }
        public float Rate { get; set; }
        public string? ImageName { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Description { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? AppUserId { get; set; }
        public string? AppUserName { get; set; }
        public string? AppUserProfileImageName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
