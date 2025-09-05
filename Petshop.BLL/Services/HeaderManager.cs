using Microsoft.EntityFrameworkCore;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.Header;
using Petshop.DAL.DataContext;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.Services
{
    public class HeaderManager : IHeaderService
    {
        private readonly AppDbContext _dbContext;

        public HeaderManager(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<HeaderViewModel> GetHeaderAsync()
        {
            var headerViewModel = new HeaderViewModel
            {
                Logo = await _dbContext.Logos
                .OrderByDescending(x => x.CreatedAt)
                .FirstOrDefaultAsync(),

                ContactInfo = await _dbContext.ContactInfos
                .OrderByDescending(x => x.CreatedAt)
                .FirstOrDefaultAsync() ?? new ContactInfo { Phone = "000-00-00", Email = "something@mail.com" },

                SearchInfo = await _dbContext.SearchInfos
                .OrderByDescending(x => x.CreatedAt)
                .FirstOrDefaultAsync() ?? new SearchInfo()
            };

            return headerViewModel;
        }
    }
}
