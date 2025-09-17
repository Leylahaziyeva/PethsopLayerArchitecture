namespace Petshop.BLL.ViewModels.Blog
{
    public class CreateBlogViewModel
    {
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public string ImageName { get; set; } = null!;
        public DateTime PublishDate { get; set; }
    }
}
