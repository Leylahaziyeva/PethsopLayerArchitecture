namespace Petshop.DAL.DataContext.Entities
{
    public class NewsletterInfo : TimeStample
    {
        public required string Title { get; set; } 
        public required string Description { get; set; } 
        public string Placeholder { get; set; } = "Enter your email here";
        public required string Icon { get; set; } 
        public string ActionUrl { get; set; } = "#";
    }
}
