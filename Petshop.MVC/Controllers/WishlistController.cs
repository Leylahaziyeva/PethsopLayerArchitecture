using Microsoft.AspNetCore.Mvc;
using Petshop.BLL.Services;

namespace Petshop.MVC.Controllers
{
    public class WishlistController : Controller
    {
        private readonly WishlistManager _wishlistManager;

        public WishlistController(WishlistManager wishlistManager)
        {
            _wishlistManager = wishlistManager;
        }
        public async Task<IActionResult> Index()
        {
            var wishlist = await _wishlistManager.GetWishlistAsync();
            return View(wishlist);
        }

        [HttpPost]
        public IActionResult AddToWishlist(int productId)
        {
            _wishlistManager.AddToWishlist(productId);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> GetWishlist()
        {
            var wishlist = await _wishlistManager.GetWishlistAsync();
            return View("Index", wishlist);
        }

        [HttpPost]
        public IActionResult RemoveFromWishlist(int productId)
        {
            _wishlistManager.RemoveFromWishlist(productId);
            return RedirectToAction("Index");
        }
    }
}
