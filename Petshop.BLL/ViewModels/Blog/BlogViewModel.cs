namespace Petshop.BLL.ViewModels.Blog
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public string ImageName { get; set; } = null!;
        public DateTime PublishDate { get; set; }
    }
}
