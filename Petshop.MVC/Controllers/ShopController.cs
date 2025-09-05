using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petshop.BLL.Services.Contracts;

namespace Petshop.MVC.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopService _shopService;
        private readonly IProductService _productService;

        public ShopController(IShopService shopService, IProductService productService)
        {
            _shopService = shopService;
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _shopService.GetShopViewModelAsync();

            ViewBag.ProductCount = model.Products.Count;

            model.Products = model.Products.Take(3).ToList();

            return View(model);
        }

        public async Task<IActionResult> Partial(int skip)
        {
            var products = await _productService.GetAllAsync(include: q => q.Include(p => p.Category!));

            var pagedProducts = products.Skip(skip).Take(3).ToList();

            return PartialView("_ProductPartialForLoadMore", pagedProducts);
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _productService.GetByIdWithDetailsAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
