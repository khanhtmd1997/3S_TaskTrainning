using System.Collections.Generic;
using System.Threading.Tasks;
using TaskTranning.Models;
using TaskTranning.ViewModels;

namespace TaskTranning.Services.Interface
{
    public interface IUserServices
    {
        bool Login(string email, string password);
        Task<UserViewModel> GetEmail(string email);
        Task<List<UserViewModel>> GetListAsync();
        Task<bool> CreateUser(AddUserViewModel userView);
        Task<bool> EditUser(EditUserViewModel userEdit);
        Task<bool> DeleteUser(int id);
        Task<EditUserViewModel> GetId(int? id);
        Task<EditPasswordUserViewModel> GetIdPassword(int? id);
        Task<bool> EditPassword(EditPasswordUserViewModel editPasswordUser);
        IEnumerable<User> GetUsers();
    }
}