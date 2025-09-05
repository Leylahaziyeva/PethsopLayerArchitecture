using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.ViewModels.Footer
{
    public class FooterViewModel
    {
        public Logo Logo { get; set; } = null!;
        public List<SocialLink> SocialLinks { get; set; } = [];
        public NewsletterInfo? Newsletter { get; set; }
        public FooterBottom Bottom { get; set; } = null!;
    }
}
