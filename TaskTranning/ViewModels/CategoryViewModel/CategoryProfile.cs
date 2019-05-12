using AutoMapper;

namespace TaskTranning.AllViewModels.Category
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Models.Category, CategoryViewModel>();
        }
    }
}