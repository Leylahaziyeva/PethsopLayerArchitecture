using AutoMapper;
using Petshop.BLL.Constants;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels.Category;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.Repositories.Contracts;

namespace Petshop.BLL.Services
{
    public class CategoryManager : CrudManager<Category, CategoryViewModel, CreateCategoryViewModel, UpdateCategoryViewModel>, ICategoryService
    {
        private readonly FileService _fileService;
        public CategoryManager(IRepository<Category> respository, IMapper mapper, FileService fileService) : base(respository, mapper)
        {
            _fileService = fileService;
        }

        public override async Task CreateAsync(CreateCategoryViewModel createViewModel)
        {
            if (createViewModel.ImageFile != null)
            {
                createViewModel.ImageName = await _fileService.GenerateFile(createViewModel.ImageFile, FilePathConstants.CategoryImagePath);
            }
            await base.CreateAsync(createViewModel);
        }

        public override async Task<bool> UpdateAsync(int id, UpdateCategoryViewModel model)
        {
            if (model.ImageFile != null)
            {
                var oldImageName = model.ImageName;
                model.ImageName = await _fileService.GenerateFile(model.ImageFile, FilePathConstants.CategoryImagePath);

                if (System.IO.File.Exists(Path.Combine(FilePathConstants.CategoryImagePath, oldImageName ?? string.Empty)))
                {
                    System.IO.File.Delete(Path.Combine(FilePathConstants.CategoryImagePath, oldImageName ?? string.Empty));
                }
            }

            return await base.UpdateAsync(id, model);
        }
    }
}
