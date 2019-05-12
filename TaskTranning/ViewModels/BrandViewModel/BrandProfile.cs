using AutoMapper;
using TaskTranning.Models;

namespace TaskTranning.ViewModels.BrandViewModel
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<Brand, BrandViewModel>();
        }
    }
}