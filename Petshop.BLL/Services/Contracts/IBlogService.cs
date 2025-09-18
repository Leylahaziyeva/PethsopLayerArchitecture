using Petshop.BLL.ViewModels.Blog;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.Services.Contracts
{
    public interface IBlogService : ICrudService<Blog, BlogViewModel, CreateBlogViewModel, UpdateBlogViewModel>
    {
        Task<List<BlogViewModel>> GetLatestAsync(int count);
    }
}