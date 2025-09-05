using Petshop.BLL.ViewModels.Shop;

namespace Petshop.BLL.Services.Contracts
{
    public interface IShopService
    {
        Task<ShopViewModel> GetShopViewModelAsync();
    }
}
