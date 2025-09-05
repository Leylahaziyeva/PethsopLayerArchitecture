using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.Slider;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.Repositories.Contracts;

namespace Petshop.BLL.Services
{
    public class SliderManager : CrudManager<Slider, SliderViewModel, CreateSliderViewModel, UpdateSliderViewModel>, ISliderService
    {
        private readonly ISliderRepository _repository;
        private readonly IMapper _mapper;

        public SliderManager(ISliderRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<SliderViewModel>> GetSlidersByIdAsync(int id)
        {
            var sliders = await _repository.GetSliderByIdAsync(id);
            return _mapper.Map<List<SliderViewModel>>(sliders);
        }
    }
}