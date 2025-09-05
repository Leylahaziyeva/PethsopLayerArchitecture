using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.Tag;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.Repositories.Contracts;

namespace Petshop.BLL.Services
{
    public class TagManager : CrudManager<Tag, TagViewModel, CreateTagViewModel, UpdateTagViewModel>, ITagService
    {
        private readonly ITagRepository _repository;
        private readonly IMapper _mapper;

        public TagManager(ITagRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<TagViewModel>> GetTagsByProductIdAsync(int productId)
        {
            var tags = await _repository.GetTagsByProductIdAsync(productId);
            return _mapper.Map<List<TagViewModel>>(tags);
        }
        public async Task<List<TagViewModel>> GetTopTagsAsync(int count)
        {
            var tags = await _repository.GetTopTagsAsync(count);
            return _mapper.Map<List<TagViewModel>>(tags);
        }
    }
}