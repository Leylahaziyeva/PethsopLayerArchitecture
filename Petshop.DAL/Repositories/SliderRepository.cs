using Microsoft.EntityFrameworkCore;
using Petshop.DAL.DataContext;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.Repositories.Contracts;

namespace Petshop.DAL.Repositories
{
    public class SliderRepository : EfCoreRepository<Slider>, ISliderRepository
    {
        private readonly AppDbContext _dbContext;
        public SliderRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Slider>> GetSliderByIdAsync(int id)
        {
            return await _dbContext.Sliders
                .Where(s => s.Id == id)
                .ToListAsync();
        }
    }
}
