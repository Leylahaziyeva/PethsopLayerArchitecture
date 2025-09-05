using Petshop.DAL.DataContext.Entities;

namespace Petshop.DAL.Repositories.Contracts
{
    public interface ITagRepository : IRepository<Tag>
    {
        Task<List<Tag>> GetTagsByProductIdAsync(int productId);
        Task<List<Tag>> GetTopTagsAsync(int count);
    }
}
