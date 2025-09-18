using Microsoft.EntityFrameworkCore;
using Petshop.DAL.DataContext;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.Repositories.Contracts;

namespace Petshop.DAL.Repositories
{
    public class BlogRepository : EfCoreRepository<Blog>, IBlogRepository
    {
        private readonly AppDbContext _dbContext;
        public BlogRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Blog>> GetLatestAsync(int count)
        {
            return await _dbContext.Blogs.OrderByDescending(b => b.PublishDate).Take(count).ToListAsync();
        }
    }
}