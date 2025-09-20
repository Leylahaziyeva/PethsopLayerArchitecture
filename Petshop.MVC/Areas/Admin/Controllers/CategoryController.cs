using Microsoft.AspNetCore.Mvc;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.Category;

namespace Petshop.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : AdminController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var exists = (await _categoryService.GetAllAsync(c => c.Name == model.Name)).Any();
            if (exists)
            {
                ModelState.AddModelError("Name", "Category with this name already exists.");
                return View(model);
            }

            await _categoryService.CreateAsync(model);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null) return NotFound();

            var updateModel = new UpdateCategoryViewModel
            {
                Id = category.Id,
                Name = category.Name
            };

            return View(updateModel);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, UpdateCategoryViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var category = await _categoryService.GetByIdAsync(id);

            if (category == null) return NotFound();

            var exists = (await _categoryService.GetAllAsync(c => c.Name == model.Name && c.Id != id)).Any();
            if (exists)
            {
                ModelState.AddModelError("Name", "Category with this name already exists.");
                return View(model);
            }

            model.ImageName = category.ImageName;

            var updated = await _categoryService.UpdateAsync(id, model);
            if (!updated) return NotFound();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _categoryService.DeleteAsync(id);
            if (!deleted) return NotFound();

            return Json(new { IsDeleted = true });
        }
    }
}

