using Petshop.BLL.ViewModels.Review;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.Services.Contracts
{
    public interface IReviewService : ICrudService<Review, ReviewViewModel, CreateReviewViewModel, UpdateReviewViewModel>
    {
    }
}
