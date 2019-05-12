using AutoMapper;
using TaskTranning.Models;

namespace TaskTranning.ViewModels.CustomerViewModel
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
        }
    }
}