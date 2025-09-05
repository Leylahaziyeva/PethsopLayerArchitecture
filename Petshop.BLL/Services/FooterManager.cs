using Microsoft.EntityFrameworkCore;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.Footer;
using Petshop.DAL.DataContext;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.Services
{
    public class FooterManager : IFooterService
    {
        private readonly AppDbContext _dbContext;

        public FooterManager(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<FooterViewModel> GetFooterAsync()
        {
            var footerViewModel = new FooterViewModel
            {
                Logo = await _dbContext.Logos
                .OrderByDescending(x => x.CreatedAt)
                .FirstOrDefaultAsync(),

                SocialLinks = await _dbContext.SocialLinks.ToListAsync(),

                Newsletter = await _dbContext.NewsletterInfos
                .OrderByDescending(x => x.CreatedAt).FirstOrDefaultAsync()
                ?? new NewsletterInfo { Title = "Join Us", Description = "Subscribe to newsletter", Icon = "fa-envelope" },

                Bottom = await _dbContext.FooterBottoms
                .OrderByDescending(x => x.CreatedAt)
                .FirstOrDefaultAsync() ?? new FooterBottom { Copyright = "© 2025", CreditsText = "Made by", CreditsUrl = "#" }
            };

            return footerViewModel;
        }
    }
}
