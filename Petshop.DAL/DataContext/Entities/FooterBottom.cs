namespace Petshop.DAL.DataContext.Entities
{
    public class FooterBottom : TimeStample
    {
        public required string Copyright { get; set; }
        public required string CreditsText { get; set; }
        public required string CreditsUrl { get; set; } 
    }
}
