using AutoMapper;
using TaskTranning.Models;

namespace TaskTranning.ViewModels
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<Store, StoreViewModel>();
            CreateMap<Store, EditStoreViewModel>();
        }
    }
}