using Petshop.BLL.ViewModels.Footer;

namespace Petshop.BLL.Services.Contracts
{
    public interface IFooterService
    {
        Task<FooterViewModel> GetFooterAsync();
    }
}