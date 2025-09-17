using Microsoft.AspNetCore.Mvc;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.Blog;

namespace Petshop.MVC.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IActionResult> Index()
        {
            var blogs = await _blogService.GetAllAsync(orderBy: q => q.OrderByDescending(b => b.PublishDate));
            return View(blogs);
        }

        public async Task<IActionResult> Details(int id)
        {
            var blog = await _blogService.GetByIdAsync(id);

            if (blog == null) return NotFound();

            return View(blog);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateBlogViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            await _blogService.CreateAsync(model);
            return RedirectToAction(nameof(Index));          
        }

        public async Task<IActionResult> Edit(int id)
        {
            var blog = await _blogService.GetByIdAsync(id);

            if (blog == null) return NotFound();

            var updateBlogViewModel = new UpdateBlogViewModel
            {
                Title = blog.Title,
                Content = blog.Content,
                ImageName = blog.ImageName,
                PublishDate = blog.PublishDate
            };
            return View(updateBlogViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateBlogViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var updated = await _blogService.UpdateAsync(id, model);

            if (!updated) return NotFound();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _blogService.DeleteAsync(id);

            if (!deleted) return NotFound();

            return RedirectToAction(nameof(Index));
        }
    }
}