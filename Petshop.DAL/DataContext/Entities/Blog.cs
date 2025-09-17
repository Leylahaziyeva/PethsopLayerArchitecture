namespace Petshop.DAL.DataContext.Entities
{
    public class Blog : TimeStample
    {
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public string ImageName { get; set; } = null!;
        public DateTime PublishDate { get; set; }
    }
}
