using Petshop.DAL.DataContext.Entities;

namespace Petshop.DAL.Repositories.Contracts
{
    public interface IBlogRepository : IRepository<Blog>
    {
        Task<List<Blog>> GetLatestAsync(int count);
    }
}
