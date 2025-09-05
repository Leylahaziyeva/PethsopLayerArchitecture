using Petshop.BLL.ViewModels.Tag;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.Services.Contracts
{
    public interface ITagService : ICrudService<Tag, TagViewModel, CreateTagViewModel, UpdateTagViewModel>
    {
        Task<List<TagViewModel>> GetTagsByProductIdAsync(int productId);
        Task<List<TagViewModel>> GetTopTagsAsync(int count);
    }
}
