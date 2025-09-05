using AutoMapper;
using Petshop.BLL.ViewModels.Category;
using Petshop.BLL.ViewModels.Product;
using Petshop.BLL.ViewModels.Slider;
using Petshop.BLL.ViewModels.Tag;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Category, CreateCategoryViewModel>().ReverseMap();
            CreateMap<Category, UpdateCategoryViewModel>().ReverseMap();


            CreateMap<Product, ProductViewModel>()
            .ForMember(x => x.CategoryName, opt => opt.MapFrom(src => src.Category == null ? "" : src.Category.Name))
            .ForMember(x => x.ImageNames, opt => opt.MapFrom(src => src.Images.Select(i => i.ImageName).ToList()))
            .ForMember(x => x.Tags, opt => opt.MapFrom(src => src.ProductTags.Where(pt => pt.Tag != null).Select(pt => pt.Tag!.Name).ToList()))
            .ReverseMap();
            CreateMap<Product, CreateProductViewModel>().ReverseMap();
            CreateMap<Product, UpdateProductViewModel>().ReverseMap();


            CreateMap<Slider, SliderViewModel>().ReverseMap();
            CreateMap<Slider, CreateSliderViewModel>().ReverseMap();
            CreateMap<Slider, UpdateSliderViewModel>().ReverseMap();


            CreateMap<Tag, TagViewModel>().ReverseMap();
            CreateMap<Tag, CreateTagViewModel>().ReverseMap();
            CreateMap<Tag, UpdateTagViewModel>().ReverseMap();
        }
    }
}