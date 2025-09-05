using Petshop.DAL.DataContext.Entities;

namespace Petshop.DAL.Repositories.Contracts
{
    public interface ISliderRepository : IRepository<Slider>
    {
        Task<List<Slider>> GetSliderByIdAsync(int id);
    }
}
