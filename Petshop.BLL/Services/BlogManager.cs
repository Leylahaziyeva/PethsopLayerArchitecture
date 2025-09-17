using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.Blog;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.Repositories.Contracts;

namespace Petshop.BLL.Services
{
    public class BlogManager : CrudManager<Blog, BlogViewModel, CreateBlogViewModel, UpdateBlogViewModel>, IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        public BlogManager(IBlogRepository blogRepository, IMapper mapper) : base(blogRepository, mapper)
        {
            _blogRepository = blogRepository;
        }
    }
}
