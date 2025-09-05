using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.Product;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.Repositories.Contracts;

namespace Petshop.BLL.Services
{
    public class ProductManager : CrudManager<Product, ProductViewModel, CreateProductViewModel, UpdateProductViewModel>, IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductManager(IProductRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ProductViewModel>> GetByCategoryAsync(string categoryName)
        {
            var products = await _repository.GetByCategoryAsync(categoryName);
            return _mapper.Map<List<ProductViewModel>>(products);
        }

        public async Task<List<ProductViewModel>> GetBestSellingAsync(int count)
        {
            var products = await _repository.GetBestSellingAsync(count);
            return _mapper.Map<List<ProductViewModel>>(products);
        }

        public async Task<ProductViewModel?> GetByIdWithDetailsAsync(int id)
        {
            var product = await _repository.GetByIdWithDetailsAsync(id);

            if (product == null) return null;

            var productViewModel = _mapper.Map<ProductViewModel>(product);

            productViewModel.ImageNames = product.Images.Select(i => i.ImageName).ToList();

            productViewModel.CategoryName = product.Category?.Name;

            productViewModel.Tags = product.ProductTags.Where(pt => pt.Tag != null).Select(pt => pt.Tag!.Name).ToList();

            return productViewModel; 
        }
    }

}