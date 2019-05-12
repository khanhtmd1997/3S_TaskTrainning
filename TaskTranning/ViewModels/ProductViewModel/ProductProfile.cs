using AutoMapper;
using TaskTranning.Models;

namespace TaskTranning.ViewModels.ProductViewModel
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<Product, ActionProductViewModel>();
        }
    }
}