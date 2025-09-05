using Petshop.BLL.ViewModels.Header;

namespace Petshop.BLL.Services.Contracts
{
    public interface IHeaderService
    {
        Task<HeaderViewModel> GetHeaderAsync();
    }
}