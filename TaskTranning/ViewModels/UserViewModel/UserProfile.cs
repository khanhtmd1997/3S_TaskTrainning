using AutoMapper;
using TaskTranning.Models;

namespace TaskTranning.ViewModels
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<User, AddUserViewModel>();
            CreateMap<User, EditPasswordUserViewModel>();
            CreateMap<User, EditUserViewModel>();
        }
    }
}