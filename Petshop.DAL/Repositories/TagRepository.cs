using Microsoft.EntityFrameworkCore;
using Petshop.DAL.DataContext;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.Repositories.Contracts;

namespace Petshop.DAL.Repositories
{
    public class TagRepository : EfCoreRepository<Tag>, ITagRepository
    {
        private readonly AppDbContext _dbContext;
        public TagRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Tag>> GetTagByIdAsync(int id)
        {
            return await _dbContext.Tags
                .Where(t => t.Id == id)
                .ToListAsync();
        }
        public Task<List<Tag>> GetTagsByProductIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Tag>> GetTopTagsAsync(int count)
        {
            throw new NotImplementedException();
        }
    }
}
