using Petshop.BLL.ViewModels.Slider;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.Services.Contracts
{
    public interface ISliderService : ICrudService<Slider, SliderViewModel, CreateSliderViewModel, UpdateSliderViewModel>
    {
        Task<List<SliderViewModel>> GetSlidersByIdAsync(int id);
    }
}
